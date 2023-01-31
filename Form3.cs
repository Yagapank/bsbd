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

{   enum RowState
    {
        New,
        Deleted,
        ModifiedNew,
        Modified,
        Existed,
    }


    public partial class Form3 : Form
    {
        DataBase1 dataBase = new DataBase1();

        int selectedRow;

        public Form3()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void CreateColums()
        {
            dataGridView2.Columns.Add("id_reguest", "Номер Заявки");
            dataGridView2.Columns.Add("id_tariff", "Тариф");
            dataGridView2.Columns.Add("date_of", "Дата");
            dataGridView2.Columns.Add("id_empoloyee", "id_Сотрудника");
            dataGridView2.Columns.Add("phone_number", "Номер_телефона");
            dataGridView2.Columns.Add("IsNew", String.Empty);
        }

        private void ReadSingleRow(DataGridView dgw, IDataRecord record)
        {
            dgw.Rows.Add(record.GetInt32(0), record.GetInt32(1), record.GetString(2), record.GetInt32(3), record.GetInt32(4), RowState.ModifiedNew);
        }

        private void RefreshDataGrid(DataGridView dgw)
        {
            dgw.Rows.Clear();

            string queryString = $"select * from zayvka";

            SqlCommand command = new SqlCommand(queryString, dataBase.getConnection());

            dataBase.openConnection();

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                ReadSingleRow(dgw, reader);
            }
            reader.Close();
        }

        private void Form3_Load_1(object sender, EventArgs e)
        {
            CreateColums();
            RefreshDataGrid(dataGridView2);
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form5 frm5 = new Form5();
            frm5.Show();
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;

            if(e.RowIndex >=0 )
            {
                DataGridViewRow row = dataGridView2.Rows[selectedRow];

                textBox5.Text = row.Cells[0].Value.ToString();
                textBox6.Text = row.Cells[1].Value.ToString();
                textBox7.Text = row.Cells[2].Value.ToString();
                textBox8.Text = row.Cells[3].Value.ToString();
                textBox9.Text = row.Cells[4].Value.ToString();
            }


        }

        private void Search(DataGridView dgw)
        {
            dgw.Rows.Clear();

            string searchString = $"select * from zayvka where concat (id_tariff, date_of, id_employee, phone_number) like '%" + textBox4.Text + "%'";

            SqlCommand com = new SqlCommand(searchString, dataBase.getConnection());
            
            dataBase.openConnection();

            SqlDataReader read = com.ExecuteReader();

            while( read.Read())
            {
                ReadSingleRow(dgw, read);
            }
            read.Close();
        }

        private void deleteRow()
        {
            int index = dataGridView2.CurrentCell.RowIndex;

            dataGridView2.Rows[index].Visible = false;
            
            if (dataGridView2.Rows[index].Cells[0].Value.ToString() == string.Empty)
            {
                dataGridView2.Rows[index].Cells[5].Value = RowState.Deleted;

                return;
            }

            dataGridView2.Rows[index].Cells[5].Value = RowState.Deleted;
        }

        private void uupdate()
        {
            dataBase.openConnection();

            for(int index = 0; index < dataGridView2.Rows.Count; index++)
            {
                var rowState = (RowState)dataGridView2.Rows[index].Cells[5].Value;

                if (rowState == RowState.Existed)
                    continue;

            if (rowState == RowState.Deleted)
                {
                    var id = Convert.ToInt32(dataGridView2.Rows[index].Cells[0].Value);

                    var deletQuery = $"delete from zayvka where id_reguest = {id}";

                    var command = new SqlCommand(deletQuery, dataBase.getConnection());

                    command.ExecuteNonQuery();
                }

                if (rowState == RowState.Modified)
                {
                    var id_2 = dataGridView2.Rows[index].Cells[0].Value.ToString();
                    var tariff_2 = dataGridView2.Rows[index].Cells[1].Value.ToString();
                    var date_2 = dataGridView2.Rows[index].Cells[2].Value.ToString();
                    var sot_2 = dataGridView2.Rows[index].Cells[3].Value.ToString();
                    var tele_2 = dataGridView2.Rows[index].Cells[4].Value.ToString();

                    var changeQuery = $"update zayvka set id_tariff = '{tariff_2}', date_of = '{date_2}', id_employee = '{sot_2}', phone_number = '{tele_2}'";

                    var command = new SqlCommand(changeQuery, dataBase.getConnection());

                    command.ExecuteNonQuery();

                }
            }

            dataBase.closeConnection();
        }


        private void Change()
        {
            var selectedRowIndex = dataGridView2.CurrentCell.RowIndex;

            var id_2 = textBox5.Text;
            var tariff_2 = textBox6.Text;
            var date_2 = textBox7.Text;
            var sot_2 = textBox8.Text;
            var tele_2 = textBox9.Text;

            dataGridView2.Rows[selectedRowIndex].SetValues(id_2, tariff_2, date_2, sot_2, tele_2);

            dataGridView2.Rows[selectedRowIndex].Cells[5].Value = RowState.Modified;
 



        }



        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            RefreshDataGrid(dataGridView2);
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            Search(dataGridView2);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Change();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            uupdate();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            deleteRow();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form6 frm6 = new Form6();
            frm6.Show();
        }

        private void textBox_sot1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            Form7 frm7 = new Form7();
            frm7.Show();
        }
    }
}
