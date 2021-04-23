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
    public partial class UserControl5 : UserControl
    {

        string constring = "server=127.0.0.1;database=pharmacydb;uid=root;pwd=khan61814;";
        BItems obj = new BItems();
        Items itm = new Items();
        public UserControl5()
        {
            InitializeComponent();
        }

        private void UserControl5_Load(object sender, EventArgs e)
        {
            BItems bitm = new BItems();
            dataGridView1.DataSource = bitm.viewItm();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            itm.ID = textBox1.Text;
            itm.Name = textBox2.Text;
            itm.CCode = textBox3.Text;
            itm.PSize = textBox4.Text;
            itm.TPrize = textBox5.Text;
            itm.RPrize = textBox6.Text;
            itm.SDiscount = textBox7.Text;
            itm.Stock = textBox7.Text;
            itm.SCode = textBox7.Text;
            int count = obj.IItm(itm);
            if (count > 0)
            {
                MessageBox.Show("Inserted!");
            }

            BItems bitm = new BItems();
            dataGridView1.DataSource = bitm.viewItm();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            itm.ID = textBox1.Text;
            itm.Name = textBox2.Text;
            itm.CCode = textBox3.Text;
            itm.PSize = textBox4.Text;
            itm.TPrize = textBox5.Text;
            itm.RPrize = textBox6.Text;
            itm.SDiscount = textBox7.Text;
            itm.Stock = textBox7.Text;
            itm.SCode = textBox7.Text;
            int count = obj.UItm(itm);
            if (count > 0)
            {
                MessageBox.Show("Updated!");
            }

            BItems bitm = new BItems();
            dataGridView1.DataSource = bitm.viewItm();
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
                textBox8.Text = row.Cells[7].Value.ToString();
                textBox8.Text = row.Cells[8].Value.ToString();
                textBox10.Text = row.Cells[9].Value.ToString();
            }
        }
    }
}
