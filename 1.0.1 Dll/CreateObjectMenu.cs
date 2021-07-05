using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dll1
{
    struct CompObjectType
    {
        struct TypeValues
        {
            public TypeValues(CompObjectType ns = new CompObjectType())
            {
                Console = ns;
                Window = ns;
                Binray = ns;
                Default = Binray;
                Console.Value = 0x3;
                Window.Value = 0x26;
                Binray.Value = 0x2;
                Default.Value = 0x3;
            }
            internal CompObjectType Console;
            internal CompObjectType Window;
            internal CompObjectType Binray;
            internal CompObjectType Default;
        }
        internal int Value;
        internal object Empty { get => new object(); }
        public static CompObjectType GetType(int id)
        {
            CompObjectType thisc = new CompObjectType();
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
                    return (CompObjectType)thisc.Empty;
            }
        }
    }
    public struct ObjectSetting
    {
        string Name;
        CompObjectType ObjType;
        Icon ObjectImage;
    }
    public partial class CreateObjectMenu : Form
    {
        Obj
        CompObjectType cot;

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
            cot = CompObjectType.GetType(ObjectType.SelectedIndex);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.
        }
    }
}
