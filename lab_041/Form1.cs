using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab_041
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            this.Text = "Сохраняю копию БО в ВМР-файл";

            button1.Text = "Сохранить";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            IDataObject data = Clipboard.GetDataObject();

            Bitmap bitmap;

            if (data.GetDataPresent(DataFormats.Bitmap) == true)
            {
                bitmap = (Bitmap)data.GetData(DataFormats.Bitmap);

                bitmap.Save(@"e:\clip.bmp");

                MessageBox.Show(@"Изображение сохранено из БО в файл e:\clip.bmp", "Успех");
            } else
            {
                MessageBox.Show("В буфере обмена нет данных в формате Bitmap", "Запишите изображение в БО");
            }
        }
    }
}
