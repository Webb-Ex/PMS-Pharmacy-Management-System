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
    public partial class UserControl3 : UserControl
    {

        string constring = "server=127.0.0.1;database=pharmacydb;uid=root;pwd=khan61814;";
        BArea obj = new BArea();
        Area ar = new Area();
        public UserControl3()
        {
            InitializeComponent();
        }

        private void UserControl3_Load(object sender, EventArgs e)
        {
            BArea bare = new BArea();
            dataGridView1.DataSource = bare.viewar();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ar.ID = textBox1.Text;
            ar.Name = textBox2.Text;
      
            int count = obj.Iar(ar);
            if (count > 0)
            {
                MessageBox.Show("Inserted!");
            }

            BArea bare = new BArea();
            dataGridView1.DataSource = bare.viewar();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ar.ID = textBox1.Text;
            ar.Name = textBox2.Text;
            
            int count = obj.Uar(ar);
            if (count > 0)
            {
                MessageBox.Show("Updated");
            }

            BArea bare = new BArea();
            dataGridView1.DataSource = bare.viewar();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];

                textBox1.Text = row.Cells[0].Value.ToString();
                textBox2.Text = row.Cells[1].Value.ToString();
                
            }
        }
    }
}
