using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using setting = System.Boolean;
namespace APICODE
{
    /* API内部发生的错误(总的来说只要捕获这个错误，API里面的错误基本上就无路可逃了) */
    class APIException : Exception
    {
        public string error { get; set; }
        public Exception inner { get; set; }
        public APIException() : base()
        {

        }

        public APIException(string Msg) : base(Msg)
        {
            this.error = Msg;
        }

        public APIException(string Msg, Exception inner) : base(Msg, inner)
        {
            error = Msg;
            this.inner = inner;
        }

        public string GetError()
        {
            return error;
        }
    }

    public delegate T CallApi<T>();
}
namespace APICODE.Function.Code
{
    public class DEFINFOFUNCTION
    {
        
        private Dll1.WindowAndFunction pros;
        public DEFINFOFUNCTION(Dll1.WindowAndFunction pro)
        {
            pros = pro;
        }
        /// <summary>
        /// 获取程序的设置
        /// </summary>
        /// <returns>一个字符串数组</returns>
        public string[] GetExeInfo()
        {
            string[] info = new string[10];
            return info;
        }

        /// <summary>
        /// 获取程序运行时的标题
        /// </summary>
        /// <returns>一个字符串</returns>
        public string GetExeTitle() => pros.Text;
        /// <summary>
        /// 获取程序的图标
        /// </summary>
        /// <returns>Bitmap类型</returns>
        public System.Drawing.Icon GetExeIcon() => pros.Icon;
        /// <summary>
        /// 获取程序的窗口边框类型
        /// </summary>
        /// <returns>BorderStyle类型</returns>
        public FormBorderStyle GetExeFromBorderStyle() => pros.FormBorderStyle;
        /// <summary>
        /// 获取程序窗口有什么控件
        /// </summary>
        /// <returns>ControlCollection类型</returns>
        public Control.ControlCollection GetExeFromControls() => pros.Controls;
        /// <summary>
        /// 获取程序的名字
        /// </summary>
        /// <returns><一个字符串/returns>
        public string GetExeMainWindowName() => pros.Name;
        /// <summary>
        /// 获取输入框内的代码
        /// </summary>
        /// <returns>一个字符串</returns>
        public string GetExeCodeText() => pros.Code.Text;
        /// <summary>
        /// 获取打开的文件的名字
        /// </summary>
        /// <returns>一个字符串</returns>
        public string GetExeOpenFileName() => pros.openFileDialog1.FileName;
        /// <summary>
        /// 获取保存的文件的名字
        /// </summary>
        /// <returns>一个字符串</returns>
        public string GetExeSaveFileName() => pros.saveFileDialog2.FileName;
        /// <summary>
        /// 获取窗口是否启用
        /// </summary>
        /// <returns>一个布尔类型（true（1） 和 false（0））</returns>
        public bool GetExeMainWindowIsEnabled() => ((pros.Enabled == true) ? true : false);
        /// <summary>
        /// 获取窗口的宽度和长度
        /// </summary>
        /// <returns>System.Drawing.Size类型</returns>
        public System.Drawing.Size GetExeMainWindowWidthAndHeigth() => pros.ClientSize;
        /// <summary>
        /// 获取程序配置文件的信息（已弃用）
        /// </summary>
        /// <returns>字符串数组</returns>
        public string[] GetExeSettings() { string[] g = new string[0]; return g; }

        /// <summary>
        /// 设置程序的标题
        /// </summary>
        /// <param name="title">标题</param>
        /// <returns>布尔类型</returns>
        public setting SetExeTitle(string title)
        {
            pros.Text = title;
            return ((pros.Text == title) ? true : false);
        }
        /// <summary>
        /// 设置窗口的边框样式
        /// </summary>
        /// <param name="Style">样式</param>
        /// <returns>布尔类型</returns>
        public setting SetExeFromBorderStyle(System.Windows.Forms.FormBorderStyle Style)
        {
            pros.FormBorderStyle = Style;
            return ((pros.FormBorderStyle == Style) ? true : false);
        }
        /// <summary>
        /// 设置图标
        /// </summary>
        /// <param name="icon">图标</param>
        /// <returns>布尔类型</returns>
        public setting SetExeIcon(System.Drawing.Icon icon)
        {
            pros.Icon = icon;
            return ((pros.Icon == icon) ? true : false);
        }
        /// <summary>
        /// 设置代码
        /// </summary>
        /// <returns>布尔类型</returns>
        public setting SetExeCodeText(string Text)
        {
            pros.Code.Text = Text;
            return ((pros.Code.Text == Text) ? true : false);
        }
        /// <summary>
        /// 设置打开的文件的名称
        /// </summary>
        /// <param name="Name">名称</param>
        /// <returns>布尔类型</returns>
        public setting SetExeOpenFileName(string Name)
        {
            return false;
        }
        /// <summary>
        /// 设置保存的文件的名称
        /// </summary>
        /// <param name="Name">名称</param>
        /// <returns>布尔类型</returns>
        public setting SetExeSaveFileName(string Name)
        {
            return false;
        }
        /// <summary>
        /// 设置窗口的启用状态
        /// </summary>
        /// <param name="IsEn">是否启用</param>
        /// <returns>布尔类型</returns>
        public setting SetExeMainWindowEnabled(bool IsEn)
        {
            pros.Enabled = IsEn;
            return ((pros.Enabled == IsEn) ? true : false);
        }
        /// <summary>
        /// 设置程序的配置文件（已弃用）
        /// </summary>
        /// <param name="Name">名称</param>
        /// <returns>布尔类型</returns>
        public setting SetExeSetting(string Name)
        {
            return false;
        }
    }
    class DEFFILEFUNCTION
    {
        StreamReader reader = new StreamReader(@"C:\Users\Administrator\Documents\RDCCodeEditConfig\configfile\config.txt");
        string config;
        /// <summary>
        /// DEFFILEFUNCTION的构造函数
        /// </summary>
        public DEFFILEFUNCTION()
        {
            config = reader.ReadToEnd();
        }
        /// <summary>
        /// 获取配置文件的内容
        /// </summary>
        /// <returns>字符串</returns>
        public string GET() => config;
        /// <summary>
        /// 获取程序路径
        /// </summary>
        /// <returns>字符串</returns>

        public string GetExePath()
        {
            return reader.ReadLine();
        }
        /// <summary>
        /// 新建配置文件
        /// </summary>
        /// <param name="name">配置文件的名字</param>
        /// <param name="text">配置文件的内容</param>
        /// <returns> StreamWrite 流</returns>
        public StreamWriter CreateConfigFile(string name, string text)
        {
            try
            {
                StreamWriter sr = new StreamWriter(name);
                sr.Write(text);
                return sr;
            }
            catch(Exception ex)
            {
                throw new APIException(ex.Message, ex.InnerException);
            }
        }

        public string ReadConfigFile(string name)
        {
            try
            {
                StreamReader sr = new StreamReader(name);
                return sr.ReadToEnd();
            }
            catch(Exception ex)
            {
                throw new APIException(ex.Message, ex.InnerException);
            }
        }

        public string ReadConfigFile(string name, uint line)
        {
            try
            {
                StreamReader sr = new StreamReader(name);
                string linestr = "";
                for(int i = 0; i <= line; i++)
                {
                    linestr = sr.ReadLine();
                }
                return linestr;
            }
            catch(Exception ex)
            {
                throw new APIException(ex.Message, ex.InnerException);
            }
        }

        public char ReadConfigFile(string name, uint line, uint strnum)
        {
            try
            {
                string linestr = "";
                StreamReader sr = new StreamReader(name);
                for(int i = 0; i <= line; i++)
                {
                    linestr = sr.ReadLine();
                }
                char letstr = '\0';
                for(int j = 0; j <= strnum; j++)
                {
                    letstr = linestr[j];
                }
                return letstr;
            }
            catch(Exception ex)
            {
                throw new APIException(ex.Message, ex.InnerException);
            }
        }

        public char ReadConfigFile(string name, uint strnum, int _ = 0)
        {
            try
            {
                string str = "";
                StreamReader sr = new StreamReader(name);
                str = sr.ReadToEnd();
                char letstr = '\0';
                for(int i = 0; i <= strnum; i++)
                {
                    letstr = str[i];
                }
                return letstr;
            }
            catch(Exception ex)
            {
                throw new APIException(ex.Message, ex.InnerException);
            }
        }

        public StreamWriter CreateConfigFile(string name)
        {
            try
            {
                StreamWriter sw = new StreamWriter(name);
                return sw;
            }
            catch(Exception ex)
            {
                throw new APIException(ex.Message, ex.InnerException);
            }
        }

        public byte ReadFileByte(string name)
        {
            try
            {
                FileStream sr = new FileStream(name, FileMode.Open);
                BinaryReader br = new BinaryReader(sr);
                return br.ReadByte();
            }
            catch(Exception ex)
            {
                throw new APIException(ex.Message, ex.InnerException);
            }
        }

        public byte[] ReadFileByte(string name, int cou)
        {
            try
            {
                FileStream fr = new FileStream(name, FileMode.Open);
                BinaryReader br = new BinaryReader(fr);
                return br.ReadBytes(cou);
            }
            catch(Exception ex)
            {
                throw new APIException(ex.Message, ex.InnerException);
            }
        }

        public int ReadFileInt(string name)
        {
            try
            {
                FileStream fr = new FileStream(name, FileMode.Open);
                BinaryReader br = new BinaryReader(fr);
                return br.ReadInt32();
            }
            catch(Exception ex)
            {
                throw new APIException(ex.Message, ex.InnerException);
            }
        }
        
        public long ReadFileInt64(string name)
        {
            try
            {
                FileStream fr = new FileStream(name, FileMode.Open);
                BinaryReader br = new BinaryReader(fr);
                return br.ReadInt64();
            }
            catch(Exception ex)
            {
                throw new APIException(ex.Message, ex.InnerException);
            }
        }

        public short ReadFileInt16(string name)
        {
            try
            {
                FileStream fr = new FileStream(name, FileMode.Open);
                BinaryReader br = new BinaryReader(fr);
                return br.ReadInt16();
            }
            catch(Exception ex)
            {
                throw new APIException(ex.Message, ex.InnerException);
            }
        }
    }
}
