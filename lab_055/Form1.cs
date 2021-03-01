using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using word = Microsoft.Office.Interop;

namespace lab_055
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            base.Text = "Построение таблицы";

            button1.Text = "Пуск";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] names = { "Андрей - раб", "Света-Х", "ЖЭК", "Справка по тел", "Александр Степанович", "Мама - дом", "Карапузова Таня", "Погода сегодня", "Театр Браво" };

            string[] phones = { "274-88-14", "+38(067)7030356", "22-345-72", "009", "223-67-67 доп 32-67", "570-38-76", "201-72-23-прямой моб", "001", "216-40-22" };

            var word1 = new word.Word.Application();

            word1.Visible = true;

            word1.Documents.Add();

            word1.Selection.TypeText("ТАБЛИЦА ТЕЛЕФОНОВ");

            word1.ActiveDocument.Tables.Add(word1.Selection.Range, 9, 2, word.Word.WdDefaultTableBehavior.wdWord9TableBehavior, word.Word.WdAutoFitBehavior.wdAutoFitContent);

            for (int i = 1; i <= 9; i++)
            {
                word1.ActiveDocument.Tables[1].Cell(i, 1).Range.InsertAfter(names[i - 1]);
                word1.ActiveDocument.Tables[1].Cell(i, 2).Range.InsertAfter(phones[i - 1]);
            }

            word1.Selection.MoveDown(word.Word.WdUnits.wdLine, 9);
            word1.Selection.TypeText("Какой-то текст после таблицы.");

           
        }
    }
}
