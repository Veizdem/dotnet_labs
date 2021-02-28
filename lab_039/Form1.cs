using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab_039
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            base.Text = "Содержимое БО:";

            button1.Text = "Извлечь из БО";

            pictureBox1.Image = Image.FromFile(@"e:\img.jpg");

            Clipboard.SetDataObject(pictureBox1.Image);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            IDataObject data = Clipboard.GetDataObject();

            Bitmap bitmap;

            if (data.GetDataPresent(DataFormats.Bitmap) == true)
            {
                bitmap = (Bitmap)data.GetData(DataFormats.Bitmap);

                pictureBox1.Image = bitmap;
            }
        }
    }
}
