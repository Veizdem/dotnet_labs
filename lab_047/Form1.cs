using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab_047
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            base.Text = "Формирование таблицы";

            string[] names = { "Андрей - раб", "Света-Х", "ЖЭК", "Справка по тел", "Александр Степанович", "Мама - дом", "Карапузова Таня", "Погода сегодня", "Театр Браво" };

            string[] phones = { "274-88-14", "+38(067)7030356", "22-345-72", "009", "223-67-67 доп 32-67", "570-38-76", "201-72-23-прямой моб", "001", "216-40-22" };

            DataTable dataTable = new DataTable();

            dataTable.Columns.Add("Имена");
            dataTable.Columns.Add("Номера телефонов");

            for (int i = 0; i <=8; i++)
            {
                dataTable.Rows.Add(new string[] { names[i], phones[i] });

            }

            dataGridView1.DataSource = dataTable;
        }
    }
}
