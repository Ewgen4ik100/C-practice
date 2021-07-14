using MySql.Data.MySqlClient;
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
    public partial class Lowlya : Form
    {
        public Lowlya()
        {
            InitializeComponent();
        }
        MySqlDataAdapter msda;
        DataTable table;
        MySqlConnection connection;
        private void SelectFromLowlya()
        {
            string connectionString = "server = localhost; port = 3306; username = root; password = root; database = fisch";
            string script = "SELECT * FROM lowlya;";
            connection = new MySqlConnection(connectionString);
            connection.Open();
            msda = new MySqlDataAdapter(script, connection);
            table = new DataTable();
            msda.Fill(table);
            dataGridView1.DataSource = table;
            connection.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SelectFromLowlya();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                label1.Visible = true;
                textBox1.Visible = true;
                Pravka.Visible = true;
            }

        }

        private void radioButton2_CheckedChanged_1(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {
                label2.Visible = true;
                textBox2.Visible = true;
                label3.Visible = true;
                textBox3.Visible = true;
                label4.Visible = true;
                textBox4.Visible = true;
                label5.Visible = true;
                textBox5.Visible = true;
                label6.Visible = true;
                textBox6.Visible = true;
                label7.Visible = true;
                textBox7.Visible = true;
                label8.Visible = true;
                textBox8.Visible = true;
                Pravka.Visible = true;
            }
            else
            {
                label2.Visible = false;
                textBox2.Visible = false;
                label3.Visible = false;
                textBox3.Visible = false;
                label4.Visible = false;
                textBox4.Visible = false;
                label5.Visible = false;
                textBox5.Visible = false;
                label6.Visible = false;
                textBox6.Visible = false;
                label7.Visible = false;
                textBox7.Visible = false;
                label8.Visible = false;
                textBox8.Visible = false;
                Pravka.Visible = false;
            }
        }

        private void radioButton3_CheckedChanged_1(object sender, EventArgs e)
        {
            if (radioButton3.Checked == true)
            {
                label1.Visible = true;
                textBox1.Visible = true;
                label2.Visible = true;
                textBox2.Visible = true;
                label3.Visible = true;
                textBox3.Visible = true;
                label4.Visible = true;
                textBox4.Visible = true;
                label5.Visible = true;
                textBox5.Visible = true;
                label6.Visible = true;
                textBox6.Visible = true;
                label7.Visible = true;
                textBox7.Visible = true;
                label8.Visible = true;
                textBox8.Visible = true;
                Pravka.Visible = true;
            }
            else
            {
                label1.Visible = false;
                textBox1.Visible = false;
                label2.Visible = false;
                textBox2.Visible = false;
                label3.Visible = false;
                textBox3.Visible = false;
                label4.Visible = false;
                textBox4.Visible = false;
                label5.Visible = false;
                textBox5.Visible = false;
                label6.Visible = false;
                textBox6.Visible = false;
                label7.Visible = false;
                textBox7.Visible = false;
                label8.Visible = false;
                textBox8.Visible = false;
                Pravka.Visible = false;
            }
        }
        private void DellEll()
        {
            try
            {
                string delcom = $"DELETE FROM lowlya WHERE id = {Convert.ToInt32(textBox1.Text)};";
                msda = new MySqlDataAdapter(delcom, connection);
                msda.Fill(table);
                SelectFromLowlya();
            }
            catch (Exception)
            {

                throw;
            }
        }
        private void AddEll()
        {
            try
            {
                string addcom = $"INSERT INTO lowlya VALUES(NULL, '{textBox2.Text}', '{textBox3.Text}', '{textBox4.Text}', '{textBox5.Text}', '{textBox6.Text}', '{textBox7.Text}', {Convert.ToInt32(textBox8.Text)});";
                msda = new MySqlDataAdapter(addcom, connection);
                msda.Fill(table);
                SelectFromLowlya();
            }
            catch (Exception)
            {

                throw;
            }
        }
        private void UpdateEll()
        {
            try
            {
                string upcom = $"UPDATE lowlya SET sudname='{textBox2.Text}', komands = '{textBox3.Text}', komandsaddres = '{textBox4.Text}',  dolznost = '{textBox5.Text}', datestart = '{textBox6.Text}', datestop = '{textBox7.Text}', fischwes = {Convert.ToInt32(textBox8.Text)}  where id = {textBox1.Text};";
                msda = new MySqlDataAdapter(upcom, connection);
                msda.Fill(table);
                SelectFromLowlya();
            }
            catch (Exception)
            {

                throw;
            }
        }
        private void Pravka_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                DellEll();
            }
            if (radioButton2.Checked == true)
            {
                AddEll();
            }
            if (radioButton3.Checked == true)
            {
                UpdateEll();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
