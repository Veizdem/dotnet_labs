using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab_019
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            this.Text = "Щелкните по ссылке";

            linkLabel1.Text = "google.com";
            linkLabel2.Text = @"Папка C:\Windows\";
            linkLabel3.Text = "Вырезать \"Блокнот\"";

            this.Font = new Font("Consolas", 12.0F);

            linkLabel1.LinkVisited = true;
            linkLabel2.LinkVisited = true;
            linkLabel3.LinkVisited = true;

            linkLabel1.LinkClicked += Link;
            linkLabel2.LinkClicked += Link;
            linkLabel3.LinkClicked += Link;
        }

        private void Link(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LinkLabel linkLabel = (LinkLabel)sender;

            switch (linkLabel.Name)
            {
                case "linkLable1":
                    System.Diagnostics.Process.Start("IExplore.exe", "http://google.com");
                    break;
                case "linkLable2":
                    System.Diagnostics.Process.Start("C:\\Windows\\");
                    break;
                case "linkLable3":
                    System.Diagnostics.Process.Start("Notepad", "text.txt");
                    break;
            }
        }
    }
}
