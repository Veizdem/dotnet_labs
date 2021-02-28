using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab_043
{
    public partial class Form1 : Form
    {
        int i = 0;

        public Form1()
        {
            InitializeComponent();

            this.Text = "Запись каждые 5 секунд в файл";
            
            button1.Text = "Пуск";

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            i++;

            this.Text = string.Format("Прошло {0} секунд", i);

            if (i >=20)
            {
                timer1.Enabled = false;

                this.Close();
            }

            if (i % 5 != 0)
            {
                return;
            }

            SendKeys.Send("%{PRTSC}");

            IDataObject data = Clipboard.GetDataObject();

            Bitmap bitmap;

            if (data.GetDataPresent(DataFormats.Bitmap) == true)
            {
                bitmap = (Bitmap)data.GetData(DataFormats.Bitmap);

                string fileName = string.Format(@"e:\scr\Pic{0}.bmp", i / 5);

                bitmap.Save(fileName);

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Text = string.Format("Прошло 0 секунд");

            timer1.Interval = 1000;
            timer1.Enabled = true;
        }
    }
}
