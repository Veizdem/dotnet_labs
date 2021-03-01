using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab_052
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            base.Text = "Web-страница и ее HTML-код";

            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;

            textBox2.Multiline = true;
            textBox2.ScrollBars = ScrollBars.Vertical;

            button1.Text = "ПУСК";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate(textBox1.Text);

        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            textBox2.Text = webBrowser1.Document.Body.InnerHtml;
        }
    }
}
