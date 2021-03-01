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

namespace lab_054
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            textBox1.Clear();

            button1.Text = "Проверка орфографии";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var word1 = new word.Word.Application();

            word1.Visible = false;

            word1.Documents.Add();

            word1.Selection.Text = textBox1.Text;

            word1.ActiveDocument.CheckSpelling();

            textBox1.Text = word1.Selection.Text;

            word1.Documents.Close(word.Word.WdSaveOptions.wdDoNotSaveChanges);

            word1.Quit();

            word1 = null;
        }
    }
}
