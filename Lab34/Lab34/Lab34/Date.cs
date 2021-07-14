using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.Linq;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab34
{
    public partial class Date : Form
    {
        public Date()
        {
            InitializeComponent();
        }

        private void Opr()
        {
            int couner = 0;
            Table<Datas> data = db.getData().GetTable<Datas>();
            foreach (Datas item in data)
            {
                dataGridView1.Rows.Add();
                dataGridView1.Rows[couner].Cells[0].Value = item.Id;
                dataGridView1.Rows[couner].Cells[1].Value = item.Opisprois;
                dataGridView1.Rows[couner].Cells[2].Value = item.Regdate;
                dataGridView1.Rows[couner].Cells[3].Value = item.Regnum;
                dataGridView1.AutoResizeColumns();
                couner++;
            }
        }
        Connections db = new Connections();
        private void Date_Load(object sender, EventArgs e)
        {
            dataGridView1.Columns.Add("Id", "Id");
            dataGridView1.Columns.Add("Options", "Options");
            dataGridView1.Columns.Add("Regdate", "Regdate");
            dataGridView1.Columns.Add("Regnum", "Regnum");
            Opr();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButton1.Checked == true)
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
        private void Add()
        {
            string str = textBox2.Text;
            DateTime dat = Convert.ToDateTime(textBox3.Text);
            int rn = Convert.ToInt32(textBox4.Text);
            Datas dt = new Datas{ Opisprois = str, Regdate = dat, Regnum = rn };
            db.getData().GetTable<Datas>().InsertOnSubmit(dt);
            db.getData().SubmitChanges();
            Opr();
        }
        private void Dell()
        {
            int ids = Convert.ToInt32(textBox1.Text);
            db.getData().GetTable<Datas>();
            var delete = from obq in db.getData().GetTable<Datas>() where obq.Id == ids select obq;
            foreach (var item in delete)
            {
                db.getData().GetTable<Datas>().DeleteOnSubmit(item);
            }
            db.getData().SubmitChanges();
            Opr();
        }
        private void Insert()
        {
            string str = textBox2.Text;
            DateTime dat = Convert.ToDateTime(textBox3.Text);
            int rn = Convert.ToInt32(textBox4.Text);
            int ids = Convert.ToInt32(textBox1.Text);
            Datas dt = new Datas();
            db.getData().GetTable<Datas>();
            var delete = from obq in db.getData().GetTable<Datas>() where obq.Id == ids select obq;
            foreach (var item in delete)
            {
                item.Opisprois = str;
                item.Regdate = dat;
                item.Regnum = rn;
                
            }
            db.getData().SubmitChanges();
            Opr();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(radioButton1.Checked == true)
            {
                Add();
            }
            if(radioButton2.Checked == true)
            {
                Dell();
                Opr();
            }
            if(radioButton3.Checked == true)
            {
                Insert();
                Opr();
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
    }
}
