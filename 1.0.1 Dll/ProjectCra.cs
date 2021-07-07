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
        
    public partial class ProjectCra : Form
    {
        public ProjectCra()
        {
            InitializeComponent();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            CreateProjectMenu com = new CreateProjectMenu(this);
            com.Show();
            Visible = false;
        }
    }
}
