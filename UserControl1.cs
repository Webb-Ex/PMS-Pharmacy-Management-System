using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BussinessAccessLayer;
using DataAccessLayer.Entities;
using MySql.Data.MySqlClient;

namespace PMS
{
    public partial class UserControl1 : UserControl
    {
        string constring = "server=127.0.0.1;database=pharmacydb;uid=root;pwd=khan61814;";
        BCustomer obj = new BCustomer();
        Customer cus = new Customer();
        public UserControl1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void UserControl1_Load(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {


        }

        private void UserControl1_Load_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void UserControl1_Load_2(object sender, EventArgs e)
        {
            BCustomer bcust = new BCustomer();
            dataGridView1.DataSource = bcust.viewCust();

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            cus.ID = textBox1.Text;
            cus.Name = textBox2.Text;
            cus.PPhone = textBox3.Text;
            cus.SPhone = textBox4.Text;
            cus.Address = textBox5.Text;
            cus.ACode = textBox6.Text;
            cus.SmanID = textBox7.Text;
            int count= obj.ICus(cus);
            if (count > 0)
            {
                MessageBox.Show("Inserted!");
            }

            BCustomer bcust = new BCustomer();
            dataGridView1.DataSource = bcust.viewCust();



        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
          
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            cus.ID = textBox1.Text;
            cus.Name = textBox2.Text;
            cus.PPhone = textBox3.Text;
            cus.SPhone = textBox4.Text;
            cus.Address = textBox5.Text;
            cus.ACode = textBox6.Text;
            cus.SmanID = textBox7.Text;
            int count = obj.UCus(cus);
            if (count > 0)
            {
                MessageBox.Show("Updated");
            }

            BCustomer bcust = new BCustomer();
            dataGridView1.DataSource = bcust.viewCust();
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
          
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];

                textBox1.Text = row.Cells[0].Value.ToString();
                textBox2.Text = row.Cells[1].Value.ToString();
                textBox3.Text = row.Cells[2].Value.ToString();
                textBox4.Text = row.Cells[3].Value.ToString();
                textBox5.Text = row.Cells[4].Value.ToString();
                textBox6.Text = row.Cells[5].Value.ToString();
                textBox7.Text = row.Cells[6].Value.ToString();
            }
        }
    }
}
