using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab_068
{
    class Program
    {
        static void Main(string[] args)
        {
            ADOX.Catalog catalog = new ADOX.Catalog();

            try
            {
                catalog.Create("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=e:\\new_DB.mdb");

                MessageBox.Show("База данных Е:\\new_DB.mdb успешно создана");
            }
            catch (System.Runtime.InteropServices.COMException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                catalog = null;
            }
        }
    }
}
