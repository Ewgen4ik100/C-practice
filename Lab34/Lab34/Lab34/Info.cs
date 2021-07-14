using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Linq;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab34
{
    public partial class Info : Form
    {
        public Info()
        {
            InitializeComponent();
        }
        Connections db = new Connections();
        private void Opr()
        {
            int couner = 0;
            Table<Inf> data = db.getData().GetTable<Inf>();
            
            foreach (Inf item in data)
            {
                dataGridView1.Rows.Add();
                dataGridView1.Rows[couner].Cells[0].Value = item.Id;
                dataGridView1.Rows[couner].Cells[1].Value = item.Regnum;
                dataGridView1.Rows[couner].Cells[2].Value = item.Resch;
                dataGridView1.Rows[couner].Cells[3].Value = item.Codeus;
                dataGridView1.AutoResizeColumns();
                couner++;
            }
        }
        private void Info_Load(object sender, EventArgs e)
        {
            dataGridView1.Columns.Add("Id", "Id");
            dataGridView1.Columns.Add("Regnum", "Regnum");
            dataGridView1.Columns.Add("Resch", "Resch");
            dataGridView1.Columns.Add("Codeus", "Codeus");
            Opr();
        }
        private void Add()
        {
            int str = Convert.ToInt32(textBox2.Text);
            string dat = textBox3.Text;
            int rn = Convert.ToInt32(textBox4.Text);
            Inf dt = new Inf { Regnum = str, Resch = dat, Codeus = rn };
            db.getData().GetTable<Inf>().InsertOnSubmit(dt);
            db.getData().SubmitChanges();
            Opr();
        }
        private void Dell()
        {
            int ids = Convert.ToInt32(textBox1.Text);
            db.getData().GetTable<Inf>();
            var delete = from obq in db.getData().GetTable<Inf>() where obq.Id == ids select obq;
            foreach (var item in delete)
            {
                db.getData().GetTable<Inf>().DeleteOnSubmit(item);
            }
            db.getData().SubmitChanges();
            Opr();
        }
        private void Insert()
        {
            int str = Convert.ToInt32(textBox2.Text);
            string dat = textBox3.Text;
            int rn = Convert.ToInt32(textBox4.Text);
            int ids = Convert.ToInt32(textBox1.Text);
            Inf dt = new Inf();
            db.getData().GetTable<Datas>();
            var delete = from obq in db.getData().GetTable<Inf>() where obq.Id == ids select obq;
            foreach (var item in delete)
            {
                item.Regnum = str;
                item.Resch = dat;
                item.Codeus = rn;

            }
            db.getData().SubmitChanges();
            Opr();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                label2.Visible = true;
                label3.Visible = true;
                label4.Visible = true;
                textBox2.Visible = true;
                textBox3.Visible = true;
                textBox4.Visible = true;
                button1.Visible = true;
            }
            else
            {
                label2.Visible = false;
                label3.Visible = false;
                label4.Visible = false;
                textBox2.Visible = false;
                textBox3.Visible = false;
                textBox4.Visible = false;
                button1.Visible = false;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {
                label1.Visible = true;
                textBox1.Visible = true;
                button1.Visible = true;
            }
            else
            {
                label1.Visible = false;
                textBox1.Visible = false;
                button1.Visible = false;
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked == true)
            {
                label1.Visible = true;
                label2.Visible = true;
                label3.Visible = true;
                label4.Visible = true;
                textBox1.Visible = true;
                textBox2.Visible = true;
                textBox3.Visible = true;
                textBox4.Visible = true;
                button1.Visible = true;
            }
            else
            {
                label1.Visible = false;
                label2.Visible = false;
                label3.Visible = false;
                label4.Visible = false;
                textBox1.Visible = false;
                textBox2.Visible = false;
                textBox3.Visible = false;
                textBox4.Visible = false;
                button1.Visible = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                Add();
            }
            if (radioButton2.Checked == true)
            {
                Dell();
                Opr();
            }
            if (radioButton3.Checked == true)
            {
                Insert();
                Opr();
            }
        }
    }
}
