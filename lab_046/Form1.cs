using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab_046
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            this.Text = "Таблица в формате HTML";

            string[] names = { "Андрей - раб", "Света-Х", "ЖЭК", "Справка по тел", "Александр Степанович", "Мама - дом", "Карапузова Таня", "Погода сегодня", "Театр Браво" };

            string[] phones = { "274-88-14", "+38(067)7030356", "22-345-72", "009", "223-67-67 доп 32-67", "570-38-76", "201-72-23-прямой моб", "001", "216-40-22" };

            string text = "<title>Пример таблицы</title>" +
                "<table border><caption>" + "Таблица телефонов</caption>\r\n";

            for (int i = 0; i <= 8; i++)
            {
                text += string.Format("<tr><td>{0}<td>{1}", names[i], phones[i]) + "\r\n";

            }

            text += "</table>";

            var writer = new System.IO.StreamWriter(@"e:\Tabl_tel.htm", false, System.Text.Encoding.GetEncoding(1251));

            writer.Write(text);
            writer.Close();

            try
            {
                System.Diagnostics.Process.Start("Iexplore", @"e:\Tabl_tel.htm");
                System.Diagnostics.Process.Start("WinWord", @"e:\Tabl_tel.htm");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
