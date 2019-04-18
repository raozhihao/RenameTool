using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RenameTool.Models
{
    public class FileExtensionStr
    {
        public static string GetFileTypeName(string FileExtension)
        {
            if (string.IsNullOrWhiteSpace(FileExtension))
            {
                return "未知文件";
            }
            string ext = FileExtension.ToLower();
            string typeName = "文件";
            switch (ext)
            {
                case ".jpg":
                case ".jpeg":
                case ".png":
                case ".bmp":
                case ".gif":
                    typeName = "图片";
                    break;
                case ".psd":
                    typeName = "PS 文件";
                    break;
                case ".cdr":
                    typeName = "CDR 文件";
                    break;
                case ".rar":
                case ".zip":
                case ".gz":
                    typeName = "压缩文件";
                    break;
                case ".txt":
                    typeName = "文本文件";
                    break;
                case ".doc":
                case ".docx":
                    typeName = "word 文档";
                    break;
                case ".xls":
                case ".xlsx":
                    typeName = "excel 文档";
                    break;
                case ".wps":
                    typeName = "wps 文档";
                    break;
                case ".html":
                     case ".htm":
                    typeName = "网页";
                    break;
                case ".pdf":
                    typeName = "pdf 文档";
                    break;
                case ".exe":
                    typeName = "应用程序";
                    break;
                case ".chm":
                    typeName = "编译的 HTML 帮助文档";
                    break;
                case ".url":
                    typeName = "Internet 快捷方式";
                    break;
                case ".js":
                    typeName = "JavaScript 文件";
                    break;
                case ".css":
                    typeName = "层叠样式表文档";
                    break;
                case ".ico":
                    typeName = "图标";
                    break;
                case ".lnk":
                    typeName = "快捷方式";
                    break;
                case ".mdf":
                    typeName = "数据库文件";
                    break;
                case ".ldf":
                    typeName = "数据库日志文件";
                    break;
                case ".sln":
                    typeName = "Visual Studio 解决方案";
                    break;
                case ".cs":
                    typeName = "Visual C#";
                    break;
                case ".pdb":
                    typeName = "程序调试数据库";
                    break;
                case ".mov":
                case ".mp4":
                case ".mpeg":
                case ".mpeg4":
                case ".mpeg-4":
                case ".avi":
                case ".rmvb":
                    typeName = "媒体文件";
                    break;
                case ".mp3":
                case ".wav":
                case ".aiff":
                case ".wma":
                case ".ape":
                case ".flac":
                case ".aac":
                    typeName = "音频文件";
                    break;
                case ".dll":
                    typeName = "应用程序扩展";
                    break;
                case ".ini":
                    typeName = "配置设置";
                    break;
                case ".resx":
                     typeName = "Microsoft.NET 托管支源文件";
                    break;
                case ".bat":
                    typeName = "Windows批处理文件";
                    break;
                default:
                    typeName = ext.Substring(ext.LastIndexOf('.') + 1) + " 文件";
                    break;
            }
            return typeName;
        }
    }
}
