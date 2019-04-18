using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace RenameTool.Models
{
    /// <summary>
    /// 获取对应路径下的图标信息,包含文件与文件夹
    /// </summary>
    public class FileIconHelper
    {
        private const uint SHGFI_ICON = 0x100;
        private const uint SHGFI_LARGEICON = 0x0;  //大图标
        private const uint SHGFI_SMALLICON = 0x1;  //小图标

        [StructLayout(LayoutKind.Sequential)]
        private struct SHFILEINFO
        {
            public IntPtr hIcon;        //文件的图标句柄  

            public IntPtr iIcon;        //图标的系统索引号  

            public uint dwAttributes;   //文件的属性值  

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 260)]
            public string szDisplayName;//文件的显示名  


            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 80)]
            public string szTypeName;   //文件的类型名  
        };

        [DllImport("shell32.dll")]
        private static extern IntPtr SHGetFileInfo(string pszPath, uint dwFileAttributes, ref SHFILEINFO psfi, uint cbSizeFileInfo, uint uFlags);

        [DllImport("User32.dll", EntryPoint = "DestroyIcon")]
        private static extern int DestroyIcon(IntPtr hIcon);


        /// <summary>
        /// 获取文件FilePath对应的Icon(文件夹也可)
        /// </summary>
        /// <param name="FilePath">文件/文件夹路径</param>
        /// <param name="isLarger">是否返回大图标</param>
        /// <returns></returns>
        public static Icon getIcon(string FilePath, bool isLarger = false)
        {
            SHFILEINFO shinfo = new SHFILEINFO();
            IntPtr iptr;
            if (isLarger)
            {
                //大图标
                iptr = SHGetFileInfo(FilePath, 0, ref shinfo, (uint)Marshal.SizeOf(shinfo), SHGFI_ICON | SHGFI_LARGEICON);
            }
            else
            {
                //小图标
                iptr = SHGetFileInfo(FilePath, 0, ref shinfo, (uint)Marshal.SizeOf(shinfo), SHGFI_ICON | SHGFI_SMALLICON);
            }

            Icon largeIcon = Icon.FromHandle(shinfo.hIcon).Clone() as Icon;

            //释放资源
            DestroyIcon(iptr);
            return largeIcon;
        }


    }
}
