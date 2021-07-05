#define Start
#define WM_SETREDRAW
using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
/*using APICODE.Function.Code;*/

namespace Dll1
{

    public partial class WindowAndFunction : Form
    {
        int row;
        static public Font font;
        static public Color color = Color.Black;

        StreamReader file;
        WindowAndFunction waf { get { return this; } }

        int iss = 0;

        private int FileModes { set; get; } = 0;

        private bool Try()
        {
            try
            {
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public void Plugmain(string tag)
        {
            API api = new API();
        }

        private void Cl(Process pro)
        {
            if (Try() == true)
            {
                pro.Start();
            }
        }

        public WindowAndFunction()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;
            //this.toolStripMenuItem1.Imag;
        }

        public void SaveFile(string filename, string code)
        {
#pragma warning disable CS4014 // 由于此调用不会等待，因此在调用完成前将继续执行当前方法
            if (Try() == true)
            {
                StreamWriter filew = new StreamWriter(filename);
                filew.Write(Code);
            }
#pragma warning restore CS4014 // 由于此调用不会等待，因此在调用完成前将继续执行当前方法
        }

        private async void ReadFile(string FileName)
        {
#pragma warning disable CS4014 // 由于此调用不会等待，因此在调用完成前将继续执行当前方法
            Task.Run(() =>
            {
                if (Try() == true)
                {
                    Code.Visible = true;
                    if (FileName != null)
                    {
                        file = new StreamReader(FileName);
                        string line;
                        while ((line = file.ReadLine()) != null)
                        {
                            Code.AppendText(line + "\n");
                        }
                        label2.Visible = false;
                    }
                }
            });
#pragma warning restore CS4014 // 由于此调用不会等待，因此在调用完成前将继续执行当前方法
        }

        private void viewToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 生成ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process pro = new Process();

            pro.StartInfo.FileName = @"Microsoft.NET\Framework\v4.0.30319\csc.exe";
            pro.StartInfo.UseShellExecute = false;
            pro.StartInfo.RedirectStandardInput = true;
             pro.StartInfo.RedirectStandardOutput = true;
            pro.StartInfo.RedirectStandardError = false;
            pro.StartInfo.CreateNoWindow = true;
            pro.StartInfo.ErrorDialog = true;

            if (FileModes == 0)
            {
                log.Visible = true;
                pro.StartInfo.Arguments = openFileDialog1.FileName;
                Start s = new Start();
                s.Show();
            }
            else if (FileModes == 1)
            {
                saveFileDialog1.ShowDialog();
                SaveFile(saveFileDialog1.FileName, Code.Text);
                pro.StartInfo.Arguments = saveFileDialog1.FileName;
                FileModes = 0;
                Start s = new Start();
                s.Show();
            }
        }


        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void 文件ToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            int a = 0;
            if (a == 1)
            {
                Code.SelectAll();
            }
            openFileDialog1.ShowDialog();
            ReadFile(openFileDialog1.FileName);
            Code.Visible = true;
            label2.Visible = false;
            linkLabel1.Visible = true;
            FileModes = 0;
            a = 1;
        }

        private void WindowAndFunction_Load(object sender, EventArgs e)
        {
            toolStripMenuItem47.Image = Properties.Resources.exit;
            menuStrip3.BackColor = Color.FromArgb(45, 45, 48);
        }

        private void WindowAndFunction_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void 文件ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Code.Visible = true;
            label2.Visible = false;
            //linkLabel1.Visible = true;
            FileModes = 1;
        }

        private void 关于ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About a = new About();
            a.Show();
            //a.BackColor = Color.Aqua;
        }

        private void menuStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void 生成ToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

        }

        private void 颜色主题ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void menuStrip3_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripMenuItem47_MouseEnter(object sender, EventArgs e)
        {
            toolStripMenuItem47.Image = (Image)Dll1.Properties.Resources.arrowexit;
        }

        private void toolStripMenuItem47_MouseLeave(object sender, EventArgs e)
        {
            toolStripMenuItem47.Image = (Image)Dll1.Properties.Resources.exit;
        }

        private void toolStripMenuItem47_Click(object sender, EventArgs e)
        {
            if (Code.Visible != false)
            {
                QSave s = new QSave(openFileDialog1.FileName, Code.Text);
                s.Show();
            }
            else
            {
                Application.ExitThread();
            }
        }

        private void toolStripMenuItem7_Click(object sender, EventArgs e)
        {

        }

        private void 保存ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFile(openFileDialog1.FileName, Code.Text);
        }

        private void Code_TextChanged(object sender, EventArgs e)
        {

        }

        private void 字体颜色ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            this.Code.ForeColor = colorDialog1.Color;
        }

        private void toolStripMenuItem1_MouseEnter(object sender, EventArgs e)
        {
            toolStripMenuItem1.BackColor = Color.FromArgb(45, 45, 48);

        }

        private void toolStripMenuItem7_MouseMove(object sender, MouseEventArgs e)
        {
            /*if (iss == 1)
            {
                this.Location = e.Location;
            }
            else
            {
                this.Location = this.Location;
            }*/
        }

        private void menuStrip3_ItemClicked_1(object sender, ToolStripItemClickedEventArgs e)
        {
            
        }

        private void toolStripMenuItem9_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void toolStripMenuItem7_MouseDown(object sender, MouseEventArgs e)
        {
            OnDragDrop(default);
        }

        private void toolStripMenuItem7_MouseUp(object sender, MouseEventArgs e)
        {

        }

        private void toolStripMenuItem7_Click_1(object sender, EventArgs e)
        {
            sgWH sw = new sgWH(this);
            sw.Show();

        }

        private void 布局设置ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("尚在开发中");
        }

        private void Ch(object sender, EventArgs e)
        {
            Console.WriteLine($"{sender.GetType().FullName} {sender.GetType().Name} {e.GetType().Name} {e.GetType().FullName}");
        }

        private void 插件ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            插件ToolStripMenuItem.Click += new EventHandler(Ch);
        }

        private void 项目ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ObjectCra cra = new ObjectCra();
            cra.ShowDialog();
        }

        private void saveFileDialog2_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void 开启系统自带边框ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (iss == 0)
            {
                this.menuStrip3.Visible = false;
                this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable;
                开启系统自带边框ToolStripMenuItem.Text = "关闭系统自带边框";
                iss = 1;
            }
            else
            {
                this.menuStrip3.Visible = true;
                this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                开启系统自带边框ToolStripMenuItem.Text = "开启系统自带边框";
                iss = 0;
            }
        }

        private void 设置ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SETTINGS settings = new SETTINGS(this);
            settings.Show();
        }

        public void fonts(Font fonts, Color colors)
        {
            Code.Font = fonts;
            Code.ForeColor = colors;
            font = fonts;
            color = colors;
        }

        private void Code_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void 文件ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CodeDeflautBox.MainWindow mainWindow = new CodeDeflautBox.MainWindow(this);
            mainWindow.Show();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void Code_KeyPress(object sender, EventArgs e)
        {
            CodeTextLen.Text = $"         字数：{Code.ToString().Length - 40}";
        }

        private async void 打开终端ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process pntvm = new Process();
            ProcessStartInfo info = new ProcessStartInfo("PNTVM\\pnt.exe");
            info.CreateNoWindow = false;
            info.UseShellExecute = false;
            info.RedirectStandardOutput = false;
            info.RedirectStandardError = false;
            info.ErrorDialog = true;
            pntvm.StartInfo = info;
            Cl(pntvm);
            
        }

        private void 文件解释ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var Result = saveFileDialog2.ShowDialog();
            if (Result == DialogResult.OK)
            {
                System.IO.StreamWriter sw = new StreamWriter(saveFileDialog2.FileName);
                sw.Write(Code.Text);
                sw.Close();
                Process pntvm = new Process();
                ProcessStartInfo info = new ProcessStartInfo("PNTVM\\pnt.exe", saveFileDialog2.FileName);
                info.CreateNoWindow = false;
                info.UseShellExecute = false;
                info.RedirectStandardOutput = false;
                info.RedirectStandardError = false;
                info.ErrorDialog = true;
                pntvm.StartInfo = info;
                Cl(pntvm);
            }
        }
        private void Code_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void Code_KeyPress(object sender, KeyPressEventArgs e)
        {/*
            int index = Code.GetFirstCharIndexOfCurrentLine();
            int row = Code.SelectionStart - index + 1;
            Code.SelectionStart = row;
            Code.Select(Code.SelectionStart, 0);
            while (Code.Find("write", RichTextBoxFinds.Reverse) != -1)
            {
                int i = Code.Find("write", RichTextBoxFinds.Reverse);
                Code.SelectionColor = Color.Blue;
                Code.SelectionStart = row;
            }
            while (Code.Find("read", RichTextBoxFinds.Reverse) != -1)
            {
                Code.Find("read", RichTextBoxFinds.Reverse);
                Code.SelectionColor = Color.Blue;
                Code.SelectionStart = row;

            }
            while (Code.Find("var", RichTextBoxFinds.Reverse) != -1)
            {
                Code.Find("var", RichTextBoxFinds.Reverse);
                Code.SelectionColor = Color.Blue;
                Code.SelectionStart = row;
            }
            while (Code.Find("var", RichTextBoxFinds.Reverse) != -1)
            {
                Code.Find("bin", RichTextBoxFinds.Reverse);
                Code.SelectionColor = Color.Blue;
                Code.SelectionStart = row;
            }
            while (Code.Find("help", RichTextBoxFinds.Reverse) != -1)
            {
                Code.Find("help", RichTextBoxFinds.Reverse);
                Code.SelectionColor = Color.Blue;
                Code.SelectionStart = row;
            }
        */}
    }

    public class Xml
    {
        public string ARead(XmlNodeList xe, int i, string aname)
        {
            return xe[i].Attributes[aname].Value;
        }
        public int ARead(XmlNodeList xe, int i, string aname, int _)
        {
            return Convert.ToInt32(xe[i].Attributes[aname].Value);
        }
    }

    public class API
    {
    }

    public interface IRDCEAPIPLUGININTERFACE
    {
        void AMain();
        void AFun();
        void AClass();
    }
}
