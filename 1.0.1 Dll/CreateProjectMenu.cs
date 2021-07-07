using System;
using System.Collections.Generic;
using System.Drawing;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security;
using System.Windows.Forms;

namespace Dll1
{
    public struct CompProjectType
    {
        public struct TypeValues
        {
            public TypeValues(CompProjectType ns = new CompProjectType())
            {
                Console = ns;
                Window = ns;
                Binray = ns;
                Default = Binray;
                Empty = ns;
                Console.Value = 0x3;
                Window.Value = 0x26;
                Binray.Value = 0x2;
                Default.Value = 0x3;
                Empty.Value = int.MinValue;
            }
            internal CompProjectType Console;
            internal CompProjectType Window;
            internal CompProjectType Binray;
            internal CompProjectType Default;
            internal CompProjectType Empty;
        }
        internal int Value;
        public static CompProjectType GetType(int id)
        {
            TypeValues tv = new TypeValues(new CompProjectType());
            switch (id)
            {
                case 1:
                    return tv.Console;
                case 2:
                    return tv.Window;
                case 3:
                    return tv.Binray;
                case 0:
                    return tv.Default;
                default:
                    return tv.Empty;
            }
        }
    }
    public struct ObjectSetting
    {
        public string Name;
        public CompProjectType ObjType;
        public Icon ObjectImage;
    }
    public partial class CreateProjectMenu : Form
    {
        class Funs
        {
            public static string GetControlText(object Control)
            {
                return Control.ToString();
            }
        }
        ObjectSetting seting = new ObjectSetting();
        private ProjectCra OC;

        public CreateProjectMenu(ProjectCra oc)
        {
            InitializeComponent();
            OC = oc;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void AllOK_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex++;

        }

        private void ObjectType_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.AutoUpgradeEnabled = true;
            var Result = openFile.ShowDialog();
            if(Result == DialogResult.OK)
            {
                seting.Name = Funs.GetControlText(ProjectName)
                    ;
                seting.ObjType = CompProjectType.GetType(ProjectType.SelectedIndex);
                if(textBox1.Text != "")
                {
                    seting.ObjectImage = Icon.ExtractAssociatedIcon(textBox1.Text);
                }
                else
                {
                    seting.ObjectImage = null;
                }
            }
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void next_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex++;
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            OC.Visible = true;
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog ProjectPath = new FolderBrowserDialog();
            ProjectPath.ShowNewFolderButton = true;
            var result = ProjectPath.ShowDialog();
            if(result == DialogResult.OK)
            {
                textBox2.Text = ProjectPath.SelectedPath;
            }
        }
    }
}
