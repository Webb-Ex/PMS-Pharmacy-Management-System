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
    public partial class UserControl2 : UserControl
    {

        string constring = "server=127.0.0.1;database=pharmacydb;uid=root;pwd=khan61814;";
        BSalesmen obj = new BSalesmen();
        Salesmen Sales = new Salesmen();
        public UserControl2()
        {
            InitializeComponent();
        }

        private void UserControl2_Load(object sender, EventArgs e)
        {
            BSalesmen bsale = new BSalesmen();
            dataGridView1.DataSource = bsale.viewSale();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Sales.ID = textBox1.Text;
            Sales.Name = textBox2.Text;
            Sales.PPhone = textBox3.Text;
            Sales.SPhone = textBox4.Text;
            Sales.Address = textBox5.Text;
            
            int count = obj.ISale(Sales);
            if (count > 0)
            {
                MessageBox.Show("Inserted!");
            }

            BSalesmen bsale = new BSalesmen();
            dataGridView1.DataSource = bsale.viewSale();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Sales.ID = textBox1.Text;
            Sales.Name = textBox2.Text;
            Sales.PPhone = textBox3.Text;
            Sales.SPhone = textBox4.Text;
            Sales.Address = textBox5.Text;

            int count = obj.USale(Sales);
            if (count > 0)
            {
                MessageBox.Show("Updated!");
            }

            BSalesmen bsale = new BSalesmen();
            dataGridView1.DataSource = bsale.viewSale();
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
                
            }
        }
    }
}
