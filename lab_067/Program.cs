using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using oleDB = System.Data.OleDb;

namespace lab_067
{
    class Program
    {
        static void Main(string[] args)
        {
            var connection = new oleDB.OleDbConnection("Data Source=\"e:\\vic.mdb\";User ID=Admin;Provider=\"Microsoft.Jet.OLEDB.4.0\";");

            connection.Open();

            var command = new oleDB.OleDbCommand("SELECT * From [Phones]", connection);

            oleDB.OleDbDataReader reader = command.ExecuteReader(System.Data.CommandBehavior.CloseConnection);

            Console.WriteLine("Таблица БД:\n");

            while (reader.Read() == true)
            {
                Console.WriteLine("{0,-3} {1, -15} {2, -15}", reader.GetValue(0), reader.GetValue(1), reader.GetValue(2));
            }

            reader.Close();
            connection.Close();

            Console.ReadKey();
        }
    }
}
