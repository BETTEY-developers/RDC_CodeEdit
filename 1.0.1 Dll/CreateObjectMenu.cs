using System;
using System.Collections.Generic;
using System.Drawing;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security;
using System.Windows.Forms;

namespace Dll1
{
    public struct CompObjectType
    {
        public struct TypeValues
        {
            public TypeValues(CompObjectType ns = new CompObjectType())
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
            internal CompObjectType Console;
            internal CompObjectType Window;
            internal CompObjectType Binray;
            internal CompObjectType Default;
            internal CompObjectType Empty;
        }
        internal int Value;
        public static CompObjectType GetType(int id)
        {
            TypeValues tv = new TypeValues(new CompObjectType());
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
        public CompObjectType ObjType;
        public Icon ObjectImage;
    }
    public partial class CreateObjectMenu : Form
    {
        class Funs
        {
            public static string GetControlText(object Control)
            {
                return Control.ToString();
            }
        }
        ObjectSetting seting = new ObjectSetting();

        public CreateObjectMenu()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void AllOK_Click(object sender, EventArgs e)
        {
            
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
                seting.Name = Funs.GetControlText(ObjectName)
                    ;
                seting.ObjType = CompObjectType.GetType(ObjectType.SelectedIndex);
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

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(tabControl1.SelectedTab == tabPage3)
            {
                while (100000 >= progressBar1.Value)
                    progressBar1.Value += 100;
            }
        }
    }
}
