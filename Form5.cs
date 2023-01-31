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
    public partial class Form5 : Form
    {
        DataBase1 dataBase = new DataBase1();

        public Form5()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form5_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "operatorDataSet2.tariff". При необходимости она может быть перемещена или удалена.
            this.tariffTableAdapter.Fill(this.operatorDataSet2.tariff);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "operatorDataSet.sot". При необходимости она может быть перемещена или удалена.
            this.sotTableAdapter.Fill(this.operatorDataSet.sot);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "operatorDataSet1.abo". При необходимости она может быть перемещена или удалена.
            this.aboTableAdapter.Fill(this.operatorDataSet1.abo);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataBase.openConnection();

            var tariff = comboBox3.Text;
            var date = textBox_date.Text;
            var sot = comboBox2.Text;
            var tele = comboBox1.Text;

            var add = $"insert into zayvka(id_tariff, date_of, id_employee, phone_number) VALUES({tariff}, '{date}', {sot}, {tele})";

            var command = new SqlCommand(add, dataBase.getConnection());
            command.ExecuteNonQuery();

            MessageBox.Show("Запись прошла успешно", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);

            dataBase.closeConnection();



        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }
    }
}
