using Microsoft.VisualBasic.Devices;
using Microsoft.VisualBasic.FileIO;
using RenameTool.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace RenameTool
{
    public partial class MainFrm : Form
    {
        ResertHelper resert = new ResertHelper();
        public MainFrm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 递增步距
        /// </summary>
        private decimal step = 1;
        /// <summary>
        /// 递增次数
        /// </summary>
        private decimal count = 1;
        /// <summary>
        /// 历史记录步数
        /// </summary>
        private int historyStep = 1;
        private RenameChose chose;

        /// <summary>
        /// 指示文件/文件夹已被重命名
        /// </summary>
        private bool renameExcute = false;
        private void Form1_Load(object sender, EventArgs e)
        {
            InitTreeView();
            comboBox1.SelectedIndex =
                cboReplaceStyle.SelectedIndex =
                cboCopy.SelectedIndex =
                cboAdd.SelectedIndex =
                0;
            chose = RenameChose.None;
            SetToolTip();
            Init();

            treeView1.SelectedFillColor =
                treeView1.SelectNoFocusedFillColor =
                Color.FromArgb(100, Color.Black);
            treeView1.NoSelectedHovedFillColor = Color.FromArgb(100, 156, 15, 36);
        }

        /// <summary>
        /// 设置弹出提示框
        /// </summary>
        private void SetToolTip()
        {
            toolTip1.SetToolTip(txtPath, "拖动或输入或点击旁边的打开按钮来跳转目录");
            toolTip1.SetToolTip(btnUp, "回到上一项");
            toolTip1.SetToolTip(btnOpenPath, "打开目录");
            toolTip1.SetToolTip(btnRefresh, "刷新当前目录");
            toolTip1.SetToolTip(btnResertUp, "返回上一次的自动编号或增加");
            toolTip1.SetToolTip(btnSaveFolder, "选择需要保存/剪切到的目录路径");
        }

        /// <summary>
        /// 初始化导航树
        /// </summary>
        private void InitTreeView()
        {
            #region 初始化树


            //获取所有驱动器信息
            DriveInfo[] drives = DriveInfo.GetDrives();
            foreach (DriveInfo drive in drives)
            {
                //只加载固定磁盘和移动磁盘
                if (drive.DriveType == DriveType.Fixed || drive.DriveType == DriveType.Removable)
                {
                    string path = drive.Name;

                    this.treeView1.Nodes.Add(GetTreeNode(path, true));
                }
            }
            //获取桌面目录
            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            this.treeView1.Nodes.Add(GetTreeNode(desktopPath));

            foreach (TreeNode node in treeView1.Nodes)
            {
                InitSubTreeNodes(node);
            }

            #endregion
        }

        /// <summary>
        /// 加载子项
        /// </summary>
        /// <param name="node"></param>
        private void InitSubTreeNodes(TreeNode node)
        {
            node.Nodes.Clear();
            treeView1.BeginUpdate();

            //拿到当前节点的全路径名称
            string fullName = node.Tag.ToString();
            //根据全名称加载所有文件夹
            try
            {
                string[] directoryInfos = Directory.GetDirectories(fullName);
                foreach (string dir in directoryInfos)
                {
                    DirectoryInfo directory = new DirectoryInfo(dir);
                    //跳过系统文件夹
                    bool re2 = directory.Attributes == (FileAttributes.Hidden | FileAttributes.System | FileAttributes.Directory);
                    if (!re2)
                    {
                        node.Nodes.Add(GetTreeNode(directory.FullName));
                    }
                }
            }
            catch
            {


            }

            treeView1.EndUpdate();
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="fullPathName">文件或文件夹全路径名称</param>
        /// <param name="isDriver">是否驱动器</param>
        /// <returns></returns>
        private TreeNode GetTreeNode(string fullPathName, bool isDriver = false)
        {
            TreeNode node = new TreeNode();
            node.Name = fullPathName;
            if (isDriver)
            {
                //驱动器
                node.Text = fullPathName;
            }
            else
            {
                node.Text = Path.GetFileName(fullPathName);
            }

            node.Tag = fullPathName;

            if (!imageList1.Images.Keys.Contains(fullPathName))
            {
                Icon icon = Models.FileIconHelper.getIcon(fullPathName);
                imageList1.Images.Add(fullPathName, icon);
            }
            node.SelectedImageKey = fullPathName;
            node.ImageKey = fullPathName;
            return node;
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

            InitSubTreeNodes(e.Node);

            this.txtPath.Text = e.Node.Tag.ToString();

            InitGridView(e.Node.Tag.ToString());
            e.Node.Expand();
            resert.Destory();
        }

        private void btnRename_Click(object sender, EventArgs e)
        {
            var dia = MessageBox.Show("请确认是否进行重命名操作,请注意,如果遇到冲突的地方,本程序将使用默认设置为您解决(将会忽略有冲突的文件)", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dia == DialogResult.No)
            {
                return;
            }
            renameExcute = true;
            LoadingHelper.ShowLoading("正在进行中,请稍候。", this, o =>
            {
                this.Invoke((Action)ExcuteRename);

            });

        }

        /// <summary>
        /// 处理重命名操作
        /// </summary>
        private void ExcuteRename()
        {
            string infoPath = Application.StartupPath;
            string savePath = txtSavePath.Text.Trim();
            //查看是否是复制或剪切
            if (cboCopy.Text != "无")
            {
                if (string.IsNullOrWhiteSpace(savePath))
                {
                    //如果当前保存的路径是空的,则保存到默认的程序启动目录下
                }
                else
                {
                    //如果不是空的,则使用此目录,如果目录不存在,会自动去创建
                    infoPath = savePath;

                }
            }
            else
            {
                //为无,则保存在原目录下

                //路径合法
                infoPath = dataGridView1.Tag.ToString();

            }

            //判断目录是否存在,如果
            if (!Directory.Exists(infoPath))
            {
                infoPath = Path.Combine(Application.StartupPath, infoPath);
            }

            var items = this.dataGridView1.Rows;
            if (items.Count <= 0)
            {
                return;
            }

            string dirPath = this.dataGridView1.Tag.ToString();//当前目录
            Dictionary<string, string> erroList = new Dictionary<string, string>();
            Computer computer = new Computer();
            foreach (DataGridViewRow item in items)
            {
                string newFileName = item.Cells[2].Value.ToString();//新名称
                string oldName = item.Cells[1].Value.ToString();//原有名称
                string oldFullFileName = Path.Combine(dirPath, item.Cells[1].Value.ToString());//原有名称
                if (oldName != newFileName)
                {
                    try
                    {
                        //文件属性
                        FileAttributes attr = File.GetAttributes(Path.Combine(dirPath, oldFullFileName));
                        if (attr == FileAttributes.Directory)
                        {
                            if (!Directory.Exists(oldFullFileName))
                            {
                                erroList.Add(oldName, "在本机中不存在");
                                continue;
                            }
                            if (cboCopy.Text == "复制")
                            {
                                computer.FileSystem.CopyDirectory(oldFullFileName, Path.Combine(savePath, newFileName));

                            }
                            else if (cboCopy.Text == "无")
                            {
                                computer.FileSystem.RenameDirectory(oldFullFileName, newFileName);
                            }
                            else
                            {
                                //剪切
                                computer.FileSystem.MoveDirectory(oldFullFileName, Path.Combine(savePath, newFileName));
                            }
                        }
                        else
                        {
                            if (!File.Exists(oldFullFileName))
                            {
                                erroList.Add(oldName, "在本机中不存在");
                                continue;
                            }
                            //是文件
                            if (cboCopy.Text == "无")
                            {
                                computer.FileSystem.RenameFile(oldFullFileName, newFileName);
                            }
                            else if (cboCopy.Text == "复制")
                            {
                                computer.FileSystem.CopyFile(oldFullFileName, Path.Combine(savePath, newFileName));
                            }
                            else
                            {
                                computer.FileSystem.MoveFile(oldFullFileName, Path.Combine(savePath, newFileName));
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        //有命名冲突或其它的项,不做处理
                        erroList.Add(item.Cells[1].Value.ToString(), ex.Message);
                    }
                }
            }

            //处理完成,刷新当前节点
            string dirFullPath = dataGridView1.Tag.ToString();
            var node = treeView1.Nodes.Find(dirFullPath, true)[0];
            treeView1_AfterSelect(null, new TreeViewEventArgs(node));

           
            string msg = "重命名完成,已保存到:" + infoPath;
            if (erroList.Count > 0)
            {
                msg += "\r\n出现以下未处理的项:\r\n";
                foreach (string key in erroList.Keys)
                {
                    msg += key + "  " + erroList[key] + "\r\n";
                }
            }
            MessageBox.Show(msg, "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private string NewName4Add(string tempName, string oldNameWithoutExt, string oldFileName)
        {
            string newFileName = oldNameWithoutExt;
            switch (cboAdd.Text)
            {
                case "无":
                    break;
                case "后缀":
                    newFileName = tempName + txtAddFill.Text;
                    break;
                case "前缀":
                    newFileName = txtAddFill.Text + tempName;
                    break;
                case "前缀+后缀":
                    newFileName = txtAddFill.Text + tempName + txtAddFill.Text;
                    break;
            }
            resert.Insert(new HistoryObj() { NewName = newFileName, OldName = tempName, Serial = historyStep, StartName = oldFileName });
            return newFileName;
        }

        /// <summary>
        /// 根据自动编号框得到新名称
        /// </summary>
        /// <returns></returns>
        private string NewName4Combox(string tempName, string oldName, string oldFileName)
        {
            string newFileName = Path.GetFileNameWithoutExtension(oldName);

            decimal temp = (step * count) + npdStart.Value - step;
            switch (comboBox1.Text)
            {
                case "无":

                    break;
                case "后缀":
                    newFileName = tempName + txtFill.Text + temp;
                    break;
                case "前缀":
                    newFileName = temp + txtFill.Text + tempName;
                    break;
                case "前缀+后缀":
                    newFileName = temp + txtFill.Text + tempName + txtFill.Text + temp;
                    break;
            }
            count++;
            resert.Insert(new HistoryObj() { NewName = newFileName, OldName = tempName, Serial = historyStep, StartName = oldFileName });
            return newFileName;
        }


        private void btnOpenPath_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowser = new FolderBrowserDialog();
            var dia = folderBrowser.ShowDialog();
            if (dia == DialogResult.OK)
            {
                txtPath.Text = folderBrowser.SelectedPath;
                txtPath_Leave(null, null);
            }
        }

        private void InitRecursionFindParentTree(string fullPath)
        {
            if (Directory.Exists(fullPath))
            {
                //找到当前树的上一级树是否存在
                var node = treeView1.Nodes.Find(fullPath, true);
                if (node.Count() > 0)
                {
                    //如果存在
                    TreeNode tempNode = node[0];
                    InitSubTreeNodes(tempNode);
                    // InitRecursionFindParentTree(Path.GetDirectoryName(fullPath));
                    if (tempNode.Parent != null)
                    {
                        tempNode.Parent.ExpandAll();
                    }
                    else
                    {
                        tempNode.ExpandAll();
                    }
                }
                else
                {
                    InitRecursionFindParentTree(Path.GetDirectoryName(fullPath));
                }
                InitRecursionSubTree(fullPath);
            }
            else
            {
                //不存在,获取上一级
                //txtPath.Text= Path.GetDirectoryName(fullPath);
            }
        }

        private void InitRecursionSubTree(string fullPath)
        {
            var node = treeView1.Nodes.Find(fullPath, true);
            if (node.Count() > 0)
            {
                TreeNode tempNode = treeView1.Nodes.Find(fullPath, true)[0];
                InitSubTreeNodes(tempNode);
                treeView1_AfterSelect(null, new TreeViewEventArgs(tempNode));
            }
        }


        private void btnUp_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Tag != null)
            {
                var rootPath = dataGridView1.Tag.ToString();
                var upPath = Path.GetDirectoryName(rootPath);
                var tempNode = treeView1.Nodes.Find(upPath, true);
                if (tempNode.Count() > 0)
                {
                    TreeNode node = tempNode[0];
                    treeView1.SelectedNode = node;
                    treeView1_AfterSelect(null, new TreeViewEventArgs(node));
                }
            }
        }

        private void txtPath_Leave(object sender, EventArgs e)
        {
            string floderPath = txtPath.Text.Trim();
            InitRecursionFindParentTree(floderPath);
            var node = treeView1.Nodes.Find(floderPath, true);
        }

        private void txtPath_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                txtPath_Leave(null, null);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            //拿到当前的文件夹
            if (treeView1.SelectedNode != null)
            {
                treeView1_AfterSelect(null, new TreeViewEventArgs(treeView1.SelectedNode));
            }
            else
            {
                Init();
            }
            resert.Destory();
        }

        private void btnReplaceShow_Click(object sender, EventArgs e)
        {
            chose = RenameChose.Replace;
            ChangeGridView();
        }

        private string NewName4Replace(string text)
        {
            string newFileName = text;
            //查看是普通还是正则
            bool re = cboReplaceStyle.Text == "普通";
            string oldtxt = txtOld.Text;
            if (string.IsNullOrWhiteSpace(txtOld.Text))
            {
                return text;
            }
            if (re)
            {
                newFileName = text.Replace(oldtxt, txtNew.Text);
            }
            else
            {
                newFileName = Regex.Replace(text, oldtxt, txtNew.Text);
            }

            return newFileName;

        }


        private void txtPath_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.All;                                                              //重要代码：表明是所有类型的数据，比如文件路径
            else
                e.Effect = DragDropEffects.None;
        }

        private void txtPath_DragDrop(object sender, DragEventArgs e)
        {
            string path = ((System.Array)e.Data.GetData(DataFormats.FileDrop)).GetValue(0).ToString();
            if (File.Exists(path))
            {
                //如果是文件,则只显示文件目录
                txtPath.Text = Path.GetDirectoryName(path);
            }
            else
            {
                txtPath.Text = path;
            }
        }

        private void tsmExploer_Click(object sender, EventArgs e)
        {
            Process p = new Process();
            //设置要启动的应用程序
            p.StartInfo.FileName = "cmd.exe";
            //是否使用操作系统shell启动
            p.StartInfo.UseShellExecute = false;
            // 接受来自调用程序的输入信息
            p.StartInfo.RedirectStandardInput = true;
            //输出信息
            p.StartInfo.RedirectStandardOutput = true;
            // 输出错误
            p.StartInfo.RedirectStandardError = true;
            //不显示程序窗口
            p.StartInfo.CreateNoWindow = true;
            //启动程序
            p.Start();

            string fullName = "explorer";
            var rows = this.dataGridView1.SelectedRows;
            string rootPath = dataGridView1.Tag.ToString();
            if (rows.Count > 0)
            {
                fullName = Path.Combine(rootPath, rows[0].Cells[1].Value.ToString());
            }
            else
            {
                fullName = rootPath;
            }

            //向cmd窗口发送输入信息
            p.StandardInput.WriteLine("start \"\" \"" + fullName + "\"&exit");

            p.StandardInput.AutoFlush = true;

            //获取输出信息
            //string strOuput = p.StandardOutput.ReadToEnd();
            //等待程序执行完退出进程
            p.WaitForExit();
            p.Close();

        }

        private void btnSaveFolder_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowser = new FolderBrowserDialog();
            var dia = folderBrowser.ShowDialog();
            if (dia == DialogResult.OK)
            {
                txtSavePath.Text = folderBrowser.SelectedPath;
            }
        }


        private void txtExt_Leave(object sender, EventArgs e)
        {
            chose = RenameChose.Extension;
            ChangeGridView();
        }


        private void txtExt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                txtExt_Leave(null, null);
            }
        }

        private void 往上ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnUp_Click(null, null);
        }

        private void toolOpen_Click_1(object sender, EventArgs e)
        {
            if (hitInfo != null)
            {
                DataGridViewCellEventArgs cellEventArgs = new DataGridViewCellEventArgs(hitInfo.ColumnIndex, hitInfo.RowIndex);
                dataGridView1_CellDoubleClick(null, cellEventArgs);
            }
        }

        private void toolRoot_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Tag != null)
            {
                string currentPath = dataGridView1.Tag.ToString();
                //获取根目录
                this.txtPath.Text = Path.GetPathRoot(currentPath);
                txtPath_Leave(null, null);
            }
        }

        private void btnAddShow_Click(object sender, EventArgs e)
        {
            chose = RenameChose.Add;
            ChangeGridView();
            historyStep++;
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index >= 0)
            {
                //判断当前双击的是否文件夹
                var row = dataGridView1.Rows[index];
                string colType = row.Cells["colGridType"].Value.ToString();
                if (colType == "文件夹")
                {
                    //获取当前点击的文件夹的路径
                    string rootPath = this.dataGridView1.Tag.ToString();
                    string dirName = row.Cells["colGridOldName"].Value.ToString();
                    string path = Path.Combine(rootPath, dirName);
                    if (Directory.Exists(path))
                    {
                        var ts = treeView1.Nodes.Find(path, true);

                        InitGridView(path);
                        InitSubTreeNodes(ts[0]);
                        ts[0].Expand();
                        treeView1.SelectedNode = ts[0];
                    }
                }
            }
        }

        private void btnExtShow_Click(object sender, EventArgs e)
        {
            txtExt_Leave(null, null);
        }

        DataGridView.HitTestInfo hitInfo = null;
        private void dataGridView1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {

                var rows = dataGridView1.Rows;
                foreach (DataGridViewRow row in rows)
                {
                    row.Selected = false;
                }
                hitInfo = dataGridView1.HitTest(e.X, e.Y);
                if (hitInfo.Type == DataGridViewHitTestType.Cell)
                {
                    dataGridView1.Rows[hitInfo.RowIndex].Selected = true;
                }
            }
        }


        private void txtAddFill_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                btnAddShow_Click(null, null);
            }
        }


        private void txtNew_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                btnReplaceShow_Click(null, null);
            }
        }

        private void btnStepShow_Click(object sender, EventArgs e)
        {
            step = npdStep.Value;
            count = 1;
            //获取已经选择的项
            var rows = dataGridView1.SelectedRows;
            chose = RenameChose.AutoSerial;
            ChangeGridView();
            historyStep++;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Resert();
            resert.Destory();
        }

        private void btnResertUp_Click(object sender, EventArgs e)
        {
            //返回上一次的操作
            historyStep--;
            var historys = resert.GetPrevHistorys(historyStep);
            Resert(historys);
        }



        private void fileSystemWatcher1_Created(object sender, FileSystemEventArgs e)
        {
            toolInfo.Text = "在此目录中有文件/目录被创建,请重新刷新本目录";
        }

        private void fileSystemWatcher1_Deleted(object sender, FileSystemEventArgs e)
        {
            toolInfo.Text = "在此目录中有文件/目录被删除,请重新刷新本目录";
        }

        private void fileSystemWatcher1_Renamed(object sender, RenamedEventArgs e)
        {
            if (!renameExcute)
            {
                toolInfo.Text = "在此目录中有文件/目录被更名,请重新刷新本目录";
            }

        }


        private void toolInfo_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(toolInfo.Text))
            {
                toolInfo.Visible = false;
            }
            else
            {
                toolInfo.Visible = true;
            }
        }

        private void treeView1_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {

            if (e.Button == MouseButtons.Left)
            {
                var loc = treeView1.HitTest(e.Location).Location;
                //判断当前鼠标落点位置是在左边的图标上还是在文本标签上
                bool re = loc == TreeViewHitTestLocations.PlusMinus || loc == TreeViewHitTestLocations.Label;
                if (!re)
                {
                    return;
                }
                if (e.Button == MouseButtons.Left)
                {
                    if (!e.Node.IsSelected && e.Node.IsExpanded)
                    {
                        //e.Node.Collapse(true);
                        treeView1_AfterSelect(treeView1, new TreeViewEventArgs(e.Node));
                    }
                    else if (e.Node.IsSelected && e.Node.IsExpanded)
                    {
                        e.Node.Collapse(true);
                    }
                    else
                    {
                        e.Node.Expand();
                    }
                }
            }

        }


        private void toolDelete_Click(object sender, EventArgs e)
        {
            if (hitInfo != null)
            {
                //将其删除

                //获取当前选定的项
                var rows = this.dataGridView1.SelectedRows;
                if (rows.Count > 0)
                {
                    var dia = MessageBox.Show("确定要删除吗,删除后只能手动去回收站恢复", "警告", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dia == DialogResult.No)
                    {
                        return;
                    }
                    Computer computer = new Computer();
                    var row = rows[0];
                    var path = dataGridView1.Tag.ToString();
                    string name = row.Cells[1].Value.ToString();
                    string fullPath = Path.Combine(path, name);
                    var extType = row.Cells[3].Value.ToString();
                    bool re = false;//判断是否删除成功
                    if (extType == "文件夹")
                    {
                        try
                        {
                            computer.FileSystem.DeleteDirectory(fullPath, UIOption.OnlyErrorDialogs, RecycleOption.SendToRecycleBin, UICancelOption.DoNothing);
                            re = true;
                        }
                        catch (Exception ex)
                        {

                            MessageBox.Show(ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                    }
                    else
                    {
                        try
                        {
                            computer.FileSystem.DeleteFile(fullPath, UIOption.OnlyErrorDialogs, RecycleOption.SendToRecycleBin);
                            re = true;
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                    }
                    if (re)
                    {
                        MessageBox.Show("删除成功", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        btnRefresh_Click(null, null);//刷新
                    }
                }

            }
        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.XButton1)
            {
                btnUp_Click(null, null);
            }
        }
    }

    /// <summary>
    /// 更名操作
    /// </summary>
    public enum RenameChose
    {
        /// <summary>
        /// 自动编号
        /// </summary>
        AutoSerial,
        /// <summary>
        /// 增加
        /// </summary>
        Add,
        /// <summary>
        /// 替换
        /// </summary>
        Replace,
        /// <summary>
        /// 无操作
        /// </summary>
        None,
        /// <summary>
        /// 扩展名更改
        /// </summary>
        Extension
    }
}
