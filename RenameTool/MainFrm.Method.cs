using RenameTool.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RenameTool
{
    public partial class MainFrm
    {
        /// <summary>
        /// 初始化
        /// </summary>
        private void Init()
        {
            //获取桌面路径
            string rootPath = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
            InitGridView(rootPath);
            
        }

        /// <summary>
        /// 初始化表格
        /// </summary>
        /// <param name="rootPath"></param>
        private void InitGridView(string rootPath)
        {
            dataGridView1.Rows.Clear();
            try
            {
                 fileSystemWatcher1.Path = rootPath;
                string[] dirs = Directory.GetDirectories(rootPath);
                string[] files = Directory.GetFiles(rootPath);
                this.dataGridView1.Tag = rootPath;

                foreach (string file in files)
                {
                    //不显示隐藏的文件
                    FileAttributes attributes = File.GetAttributes(file);
                    bool re = attributes == (FileAttributes.Hidden | FileAttributes.System | FileAttributes.Archive | FileAttributes.NotContentIndexed);
                    bool re2 = attributes == (FileAttributes.Hidden | FileAttributes.System | FileAttributes.Archive);
                    if (re || re2)
                    {
                        continue;
                    }
                    string name = Path.GetFileName(file);
                    Icon icon = Models.FileIconHelper.getIcon(file);
                    DateTime dt = File.GetCreationTime(file);
                    string fileType = Models.FileExtensionStr.GetFileTypeName(Path.GetExtension(file));
                    dataGridView1.Rows.Add(icon, name, name, fileType, dt);
                }
                foreach (string dir in dirs)
                {
                    bool re = File.GetAttributes(dir) == (FileAttributes.Hidden | FileAttributes.System | FileAttributes.Directory);
                    if (re)
                    {
                        continue;
                    }
                    string name = Path.GetFileName(dir);
                    Icon icon = Models.FileIconHelper.getIcon(dir);
                    DateTime dt = File.GetCreationTime(dir);
                    dataGridView1.Rows.Add(icon, name, name, "文件夹", dt);
                }
                this.txtPath.Text = rootPath;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

            ShowFileCountInfo();
            toolInfo.Text = "";
        }

        /// <summary>
        /// 显示当前文件夹的信息
        /// </summary>
        private void ShowFileCountInfo()
        {
            //找出文件夹类型
            var rows = this.dataGridView1.Rows;
            var list = rows.Cast<DataGridViewRow>().ToList();
            int dirCount = list.Count(d => d.Cells[3].Value.ToString() == "文件夹");
            toolDirInfo.Text =string.Format( "{0} 文件夹  {1} 文件",dirCount,rows.Count-dirCount);
        }

        /// <summary>
        /// 更改表格
        /// </summary>
        /// <param name="rows"></param>
        private void ChangeGridView()
        {
            var rows = this.dataGridView1.SelectedRows;
            var rowOrder = rows.Cast<DataGridViewRow>().OrderBy(r => r.Index);
            for (int i = 0; i < rowOrder.Count(); i++)
            {
                var row = rowOrder.ElementAt(i);

                string fileName = row.Cells[2].Value.ToString();

                string newFileName = fileName;

                string oldFileName = row.Cells[1].Value.ToString();
                string tempName = Path.GetFileNameWithoutExtension(fileName);
                string fileFullName = Path.Combine(dataGridView1.Tag.ToString(), oldFileName);

                string oldFileWithoutExt = Path.GetFileNameWithoutExtension(oldFileName);
                bool reu = false;
                switch (chose)
                {
                    case RenameChose.AutoSerial:
                        //根据自动编号列得到
                        newFileName = NewName4Combox(tempName, oldFileWithoutExt,oldFileName);
                        break;
                    case RenameChose.Replace:
                        //根据替换得到
                        newFileName = NewName4Replace(tempName);
                        break;
                    case RenameChose.Add:
                        newFileName = NewName4Add(tempName, oldFileWithoutExt,oldFileName);
                        break;
                    case RenameChose.Extension:
                        newFileName = ChangeExstion(tempName, fileFullName);
                        //更新当前单元格
                        row.Cells[2].Value = newFileName;
                        reu = true;//跳过此次循环
                        break;
                    case RenameChose.None:
                        break;
                }

                if (reu)
                {
                    continue;
                }

                try
                {
                    if (File.GetAttributes(fileFullName) != FileAttributes.Directory)
                    {
                        //是文件类型
                        newFileName = newFileName + Path.GetExtension(fileName);
                    }

                    //更新当前单元格
                    row.Cells[2].Value = newFileName;
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                    btnRefresh_Click(null, null);
                    break;
                }
            }
        }

        private string ChangeExstion(string tempName, string fileFullName)
        {
            string newFileName = tempName;
            if (File.GetAttributes(fileFullName) != FileAttributes.Directory)
            {
                //是文件类型
                newFileName = tempName + "." + txtExt.Text.Trim();
            }
            return newFileName;
        }
        
        /// <summary>
        /// 重置/返回上一步历史记录
        /// </summary>
        /// <param name="history"></param>
        private void Resert(List<HistoryObj> history=null)
        {
            if (history == null)
            {
                var rows = this.dataGridView1.Rows;
                foreach (DataGridViewRow row in rows)
                {
                    row.Cells[2].Value = row.Cells[1].Value;
                }
            }
            else
            {
                history.ForEach(h =>
                {
                    DataGridViewRow row = GetFirstRow(h.StartName);
                    if (row != null)
                    {
                        string ext = Path.GetExtension(row.Cells[1].Value.ToString());
                        row.Cells[2].Value = h.OldName + ext;
                    }
                });
               
            }
        }

        /// <summary>
        /// 根据指定的单元格名称找到行
        /// </summary>
        /// <param name="oldName"></param>
        /// <returns></returns>
        private DataGridViewRow GetFirstRow(string oldName)
        {
            var rows = this.dataGridView1.Rows;
            DataGridViewRow reRow = null;
            foreach (DataGridViewRow row in rows)
            {
                string path = row.Cells[1].Value.ToString();
               
                if (path==oldName)
                {
                    reRow = row;
                    break;
                }
            }
            return reRow;
        }
    }
}
