using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Runtime.Versioning;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace affairs
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("data source = DESKTOP-AHPLOR8 ; initial catalog=travel ; integrated security = true");
        SqlDataAdapter d;
        SqlCommand cmd;
        DataTable dt = new DataTable();
        string table_name="";

        private void filltable()
        {
            d = new SqlDataAdapter("select * from "+table_name,con);
            dt.Rows.Clear();
            d.Fill(dt);
            dgv.DataSource = dt;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            if(Properties.Settings.Default.password != ""&&
                Properties.Settings.Default.username != "")
            {
                login l = new login();
                l.ShowDialog();
            }
            dgv.ForeColor = Color.Black;
            comboBox1.SelectedIndex = 1;
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void termQToolStripMenuItem_Click(object sender, EventArgs e)
        {
            table_name = "class3_s1";
            filltable();
        }

        private void highSchoolToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void stSecToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void term2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            table_name = "class1_s2";
            filltable();
        }

        private void accuntToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new changesettings();
            frm.Show();
            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void signOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void term1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            table_name = "class1_s1";
            filltable();
            dgv.Columns[5].Width = 400;
        }

        private void term1ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            table_name = "class1_s2";
            filltable();
        }

        private void term1ToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            table_name = "class2_s1";
            filltable();
        }

        private void term2ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            table_name = "class2_s2";
            filltable();
        }

        private void rdSecToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            table_name = "class3_s2";
            filltable();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            SqlDataAdapter d2 = new SqlDataAdapter("select * from"+table_name+"where "+comboBox1.Text+"like '%"+search.Text+"%'", con);
            DataTable dt2 = new DataTable();
            d2.Fill(dt2);
            dgv.DataSource = dt2;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (table_name != "")
            {
                groupBox1.Enabled = true;
                count_student.Text = dgv.Rows.Count.ToString();
            }

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
