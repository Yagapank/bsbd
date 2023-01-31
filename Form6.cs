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
    public partial class Form6 : Form
    {

        DataBase1 dataBase = new DataBase1();

        public Form6()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }


        private void CreateColums()
        {
            dataGridView1.Columns.Add("id_tariff", "Тариф");
            dataGridView1.Columns.Add("ptice", "Цена");
            dataGridView1.Columns.Add("gb", "Кол-во гигабайт");
            dataGridView1.Columns.Add("sms", "Кол-во смс");
            dataGridView1.Columns.Add("minut", "Кол-во минут");
        }

        private void ReadSingleRow(DataGridView dgw, IDataRecord record)
        {
            dgw.Rows.Add(record.GetInt32(0), record.GetInt32(1), record.GetInt32(2), record.GetInt32(3), record.GetInt32(4));
        }

        private void RefreshDataGrid(DataGridView dgw)
        {
            dgw.Rows.Clear();

            string queryString = $"select * from tariff";

            SqlCommand command = new SqlCommand(queryString, dataBase.getConnection());

            dataBase.openConnection();

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                ReadSingleRow(dgw, reader);
            }
            reader.Close();
        }



        private void Form6_Load(object sender, EventArgs e)
        {
            CreateColums();
            RefreshDataGrid(dataGridView1);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            RefreshDataGrid(dataGridView1);
        }
    }
}
