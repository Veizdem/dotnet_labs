using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab_053
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            string site = "google.com";
            string form = "f";
            string field = "q";

            webBrowser1.Navigate(site);

            while (webBrowser1.ReadyState != WebBrowserReadyState.Complete)
            {
                Application.DoEvents();
                System.Threading.Thread.Sleep(50);

            }

            if (webBrowser1.Document == null)
            {
                MessageBox.Show("ERROR: Возможно отсутствует интерет");
                return;
            }

            mshtml.IHTMLDocument2 doc = (mshtml.IHTMLDocument2)webBrowser1.Document.DomDocument;

            mshtml.HTMLFormElement f = doc.forms.item(form, null);

            if (f == null)
            {
                MessageBox.Show(string.Format("ERROR: форма с именем \"{0}\" не найдена", form));
                return;
            }

            mshtml.IHTMLInputElement fld = f.namedItem(field);

            if (fld == null)
            {
                MessageBox.Show(string.Format("ERROR: поле формы с именем \"{0}\" не найдено", field));
                return;
            }

            string query = "hello world";

            fld.value = query;

            f.submit();
        }
    }
}
