using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace KyrsachOOP
{
    public partial class Form8 : Form
    {
        DataBase1 dataBase = new DataBase1();

        public Form8()

        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void Form8_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataBase.openConnection();

            var tariff = textBox_telephone.Text;
            var date = textBox_pasport.Text;
            var sot = textBox_fam.Text;
            var tele = textBox_nam.Text;
            var otch = textBox_otch.Text;

            var add = $"insert into abo (phone_number, pasport, fam, nam, otch) VALUES ({tariff}, {date}, '{sot}', '{tele}', '{otch}')";

            var command = new SqlCommand(add, dataBase.getConnection());
            command.ExecuteNonQuery();

            MessageBox.Show("Ваша заявка успешно отпралена", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);

            dataBase.closeConnection();
        }
    }
}
