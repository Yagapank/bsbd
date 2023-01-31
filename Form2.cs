using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace KyrsachOOP
{
    public partial class Form2 : Form
    {
        DataBase1 dataBase = new DataBase1();
        public Form2()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            textBox2.PasswordChar = '●';

        }

        private void button1_Click(object sender, EventArgs e)
        {

            
            var login = textBox1.Text;

            var password = textBox2.Text;

            string querystring = $"insert into reg_sot (login_user, password_user) values ('{login}', '{password}')";

            SqlCommand command = new SqlCommand(querystring, dataBase.getConnection());

            dataBase.openConnection();
            
            if (command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Аккаунт создан");
                Form2 frm_login = new Form2();
                Form1 frm1 = new Form1();
                this.Hide();
                frm1.ShowDialog();
            }
            else
            {
                MessageBox.Show("Аккаунт не создан");
            }
                

            
            
            dataBase.closeConnection();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 frm1 = new Form1();
            frm1.Show();
            this.Hide();
        }
    }
}
