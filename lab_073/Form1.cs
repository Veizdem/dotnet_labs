using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using oleDB = System.Data.OleDb;

namespace lab_073
{
    public partial class Form1 : Form
    {
        DataSet dataSet;
        oleDB.OleDbDataAdapter adapter;
        oleDB.OleDbConnection connection = new oleDB.OleDbConnection("Data Source=\"e:\\vic.mdb\";User ID=Admin;Provider=\"Microsoft.Jet.OLEDB.4.0\";");
        oleDB.OleDbCommand command = new oleDB.OleDbCommand();

        public Form1()
        {
            InitializeComponent();

            button1.Text = "Читать из БД";
            button1.TabIndex = 0;

            button2.Text = "Сохранить в БД";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataSet = new DataSet();
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }

            adapter = new oleDB.OleDbDataAdapter("Select * From [Phones]", connection);
            adapter.Fill(dataSet, "Phones");
            string strXml = dataSet.GetXml();
            dataGridView1.DataSource = dataSet;
            dataGridView1.DataMember = "Phones";

            connection.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            command.CommandText = "UPDATE [Phones] SET [phone] = ?, fio = ? WHERE ([Nn] = ?)";
            command.Parameters.Add("phone", oleDB.OleDbType.VarChar, 50, "phone");
            command.Parameters.Add("fio", oleDB.OleDbType.VarChar, 50, "fio");
            command.Parameters.Add(new oleDB.OleDbParameter("Original_Nn", oleDB.OleDbType.Integer, 0, ParameterDirection.Input, false, (byte)0, (byte)0, "Nn", DataRowVersion.Original, null));

            adapter.UpdateCommand = command;

            command.Connection = connection;

            try
            {
                int kol = adapter.Update(dataSet, "Phones");
                MessageBox.Show("Обновлено " + kol + " записей");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Недоразумение");
            }
        }
    }
}
