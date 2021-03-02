using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using oleDB = System.Data.OleDb;

namespace lab_074
{
    class Program
    {
        static void Main(string[] args)
        {
            var connection = new oleDB.OleDbConnection("Data Source=\"e:\\vic.mdb\";User ID=Admin;Provider=\"Microsoft.Jet.OLEDB.4.0\";");

            connection.Open();

            var command = new oleDB.OleDbCommand("Delete * From [Phones] Where fio Like 'Св%'", connection);

            int i = command.ExecuteNonQuery();

            if (i > 0) MessageBox.Show("Записи, содержащие в поле ФИО фрагмент 'Св*', удалены");

            if (i == 0) MessageBox.Show("Запись, содержащая в поле ФИО фрагмент 'Св*', не найдена");

            connection.Close();
        }
    }
}
