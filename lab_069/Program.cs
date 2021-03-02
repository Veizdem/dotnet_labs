using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;

using oleDB = System.Data.OleDb;

namespace lab_069
{
    class Program
    {
        static void Main(string[] args)
        {
            var connection = new oleDB.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=e:\\new_DB.mdb");

            connection.Open();

            var command = new oleDB.OleDbCommand("CREATE TABLE [Phones] ([num] counter, [fio] char(20), [phone] char(20))", connection);

            try
            {
                command.ExecuteNonQuery();
                MessageBox.Show("Структура таблицы 'Phones' записана в пустую БД");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            connection.Close();
        }
    }
}
