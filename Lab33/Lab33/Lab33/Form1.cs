using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab33
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void sudnoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sudno sudno = new Sudno();
            sudno.MdiParent = this;
            sudno.Show();
            this.LayoutMdi(MdiLayout.Cascade);
        }

        private void lowlyaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Lowlya lowlya = new Lowlya();
            lowlya.MdiParent = this;
            lowlya.Show();
            this.LayoutMdi(MdiLayout.Cascade);
        }

        private void mestLowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MestLow mestlow = new MestLow();
            mestlow.MdiParent = this;
            mestlow.Show();
            this.LayoutMdi(MdiLayout.Cascade);
        }
    }
}
