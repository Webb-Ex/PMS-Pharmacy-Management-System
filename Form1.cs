using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PMS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void b2_Click(object sender, EventArgs e)
        {
            UserControl1 user = new UserControl1();
            panel4.Controls.Clear();
            panel4.Controls.Add(user);
            
            
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void b3_Click(object sender, EventArgs e)
        {
            UserControl2 user = new UserControl2();
            panel4.Controls.Clear();
            user.Anchor = ((AnchorStyles)((((AnchorStyles.Top | AnchorStyles.Bottom)
            | AnchorStyles.Left) | AnchorStyles.Right)));
            user.Dock = DockStyle.Fill;
            panel4.Controls.Add(user);
        }

        private void b4_Click(object sender, EventArgs e)
        {
            UserControl3 user = new UserControl3();
            panel4.Controls.Clear();
            panel4.Controls.Add(user);
        }

        private void b5_Click(object sender, EventArgs e)
        {
            UserControl4 user = new UserControl4();
            panel4.Controls.Clear();
            panel4.Controls.Add(user);
        }

        private void b6_Click(object sender, EventArgs e)
        {
            UserControl5 user = new UserControl5();
            panel4.Controls.Clear();
            panel4.Controls.Add(user);
        }

        private void b7_Click(object sender, EventArgs e)
        {
            UserControl6 user = new UserControl6();
            panel4.Controls.Clear();
            panel4.Controls.Add(user);
        }

        private void b8_Click(object sender, EventArgs e)
        {
            UserControl7 user = new UserControl7();
            panel4.Controls.Clear();
            panel4.Controls.Add(user);
        }

        private void b9_Click(object sender, EventArgs e)
        {
            UserControl8 user = new UserControl8();
            panel4.Controls.Clear();
            panel4.Controls.Add(user);
        }
    }
}
