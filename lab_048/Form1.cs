using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab_048
{
    public partial class Form1 : Form
    {
        DataTable dataTable = new DataTable();
        DataSet dataSet = new DataSet();

        public Form1()
        {
            InitializeComponent();

            base.Text = "Почти табличный редактор";

            button1.Text = "Запись";

            if (System.IO.File.Exists(@"e:\tabl.xml") == false)
            {
                dataGridView1.DataSource = dataTable;

                dataTable.Columns.Add("Имена");
                dataTable.Columns.Add("Номера телефонов");

                dataSet.Tables.Add(dataTable);

            } else
            {
                dataSet.ReadXml(@"e:\tabl.xml");

                string strXML = dataSet.GetXml();

                dataGridView1.DataMember = "Название таблицы";
                dataGridView1.DataSource = dataSet;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataTable.TableName = "Название таблицы";
            dataSet.WriteXml(@"e:\tabl.xml");

        }
    }
}
