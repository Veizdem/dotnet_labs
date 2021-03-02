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

namespace lab_071
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            var connection = new oleDB.OleDbConnection("Data Source=\"e:\\vic.mdb\";User ID=Admin;Provider=\"Microsoft.Jet.OLEDB.4.0\";");

            connection.Open();

            oleDB.OleDbCommand command = new oleDB.OleDbCommand("Select * From [Phones]", connection);

            oleDB.OleDbDataReader reader = command.ExecuteReader();

            DataTable table = new DataTable();

            table.Columns.Add(reader.GetName(0));
            table.Columns.Add(reader.GetName(1));
            table.Columns.Add(reader.GetName(2));

            while (reader.Read() == true)
            {
                table.Rows.Add(new object[] { reader.GetValue(0), reader.GetValue(1), reader.GetValue(2) });

            }

            reader.Close();
            connection.Close();

            dataGridView1.DataSource = table;
        }
    }
}
