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

namespace lab_072
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            this.Text = "Чтение таблицы из БД:";

            var connection = new oleDB.OleDbConnection("Data Source=\"e:\\vic.mdb\";User ID=Admin;Provider=\"Microsoft.Jet.OLEDB.4.0\";");

            connection.Open();

            var command = new oleDB.OleDbCommand("Select * From [Phones]", connection);

            var adapter = new oleDB.OleDbDataAdapter(command);

            DataSet dataSet = new DataSet();

            adapter.Fill(dataSet, "Phones");

            string strXml = dataSet.GetXml();

            dataGridView1.DataSource = dataSet;

            dataGridView1.DataMember = "Phones";

            connection.Close();
        }
    }
}
