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
    public partial class UserControl4 : UserControl
    {

        string constring = "server=127.0.0.1;database=pharmacydb;uid=root;pwd=khan61814;";
        BSupplier obj = new BSupplier();
        Supplier spl = new Supplier();
        public UserControl4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            spl.ID = textBox1.Text;
            spl.Name = textBox2.Text;
            spl.PPhone = textBox3.Text;
            spl.SPhone = textBox4.Text;
            spl.Address = textBox5.Text;
            spl.ACode = textBox6.Text;
            
            int count = obj.Ispl(spl);
            if (count > 0)
            {
                MessageBox.Show("Inserted!");
            }

            BSupplier bspl = new BSupplier();
            dataGridView1.DataSource = bspl.viewSpl();
        }

        private void UserControl4_Load(object sender, EventArgs e)
        {
            BSupplier bspl = new BSupplier();
            dataGridView1.DataSource = bspl.viewSpl();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            spl.ID = textBox1.Text;
            spl.Name = textBox2.Text;
            spl.PPhone = textBox3.Text;
            spl.SPhone = textBox4.Text;
            spl.Address = textBox5.Text;
            spl.ACode = textBox6.Text;
            
            int count = obj.Uspl(spl);
            if (count > 0)
            {
                MessageBox.Show("Updated");
            }

            BSupplier bspl = new BSupplier();
            dataGridView1.DataSource = bspl.viewSpl();
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
                
            }
        }
    }
}
