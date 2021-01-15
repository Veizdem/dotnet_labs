using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab_026
{
    public partial class Form1 : Form
    {
        int questionCounter = 0;
        int correctAnswersCount = 0;
        int uncorrectAnswersCount = 0;
        string[] uncorrectAnswers;
        int correctAnswerId = 0;
        int selectAnswerId = 0;

        Encoding encoding = Encoding.GetEncoding(1251);
        System.IO.StreamReader reader;

        public Form1()
        {
            InitializeComponent();

            button1.Text = "Следующий вопрос";
            button2.Text = "Выход";

            radioButton1.CheckedChanged += new EventHandler(rbChanged);
            radioButton2.CheckedChanged += new EventHandler(rbChanged);
            radioButton3.CheckedChanged += new EventHandler(rbChanged);

            StartTest();
        }

        void StartTest()
        {
            try
            {
                reader = new System.IO.StreamReader(
                    System.IO.Directory.GetCurrentDirectory() +
                    @"\test.txt", encoding);

                this.Text = reader.ReadLine();

                questionCounter = 0;
                correctAnswersCount = 0;
                uncorrectAnswersCount = 0;

                uncorrectAnswers = new string[100];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка",
                    MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            }

            ReadNextQuestion();
        }

        void ReadNextQuestion()
        {
            label1.Text = reader.ReadLine();

            radioButton1.Text = reader.ReadLine();
            radioButton2.Text = reader.ReadLine();
            radioButton3.Text = reader.ReadLine();

            correctAnswerId = int.Parse(reader.ReadLine());

            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;

            button1.Enabled = false;

            questionCounter++;

            if (reader.EndOfStream == true)
            {
                button1.Text = "Завершить";
            }
        }

        private void rbChanged(object sender, EventArgs e)
        {
            button1.Enabled = true;

            RadioButton radioButton = (RadioButton)sender;

            string tmp = radioButton.Name;

            selectAnswerId = int.Parse(tmp.Substring(11));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (selectAnswerId == correctAnswerId)
            {
                correctAnswersCount++;
            } else
            {
                uncorrectAnswersCount++;
                uncorrectAnswers[uncorrectAnswersCount] = label1.Text;
            }

            if (button1.Text=="Начать тестирование сначала")
            {
                button1.Text = "Следующий вопрос";

                radioButton1.Visible = true;
                radioButton2.Visible = true;
                radioButton3.Visible = true;

                StartTest();
                
                return;
            }

            if (button1.Text=="Завершить")
            {
                reader.Close();

                radioButton1.Visible = false;
                radioButton2.Visible = false;
                radioButton3.Visible = false;

                label1.Text = string.Format(
                    "Тестирование завершено.\n" +
                    "Правильных ответов: {0} из {1}.\n" +
                    "Оценка в пятибальной системе: {2:F2}.",
                    correctAnswersCount,
                    questionCounter,
                    (correctAnswersCount * 5F) / questionCounter);

                button1.Text = "Начать тестирование сначала";

                string str = "СПИСОК ВОПРОСОВ, НА КОТОРЫЕ ВЫ ДАЛИ НЕПРАВИЛЬНЫЙ ОТВЕТ:\n\n";

                for (int i = 1; i < uncorrectAnswersCount; i++)
                {
                    str = str + uncorrectAnswers[uncorrectAnswersCount] + "\n";
                }

                if (uncorrectAnswersCount != 0)
                {
                    MessageBox.Show(str, "Тестирование завершено");
                }
            }

            if (button1.Text == "Следующий вопрос")
            {
                ReadNextQuestion();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
