using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using oleDB = System.Data.OleDb;

namespace lab_070
{
    class Program
    {
        static void Main(string[] args)
        {
            var connection = new oleDB.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=e:\\new_DB.mdb");

            connection.Open();

            var command = new oleDB.OleDbCommand("INSERT INTO [Phones] (fio, phone) VALUES ('Света-Х', '521-61-41')");

            command.Connection = connection;

            command.ExecuteNonQuery();

            MessageBox.Show("В таблицу 'Phones' добавлена запись");
            
            connection.Close();
        }
    }
}
