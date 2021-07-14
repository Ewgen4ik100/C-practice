using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab34
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void daateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Date d = new Date();
            d.MdiParent = this;
            d.Show();
            this.LayoutMdi(MdiLayout.Cascade);
        }

        private void infoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Info d = new Info();
            d.MdiParent = this;
            d.Show();
            this.LayoutMdi(MdiLayout.Cascade);
        }

        private void usersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Users d = new Users();
            d.MdiParent = this;
            d.Show();
            this.LayoutMdi(MdiLayout.Cascade);
        }
    }
}
