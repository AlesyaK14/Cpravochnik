using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp2K
{
    internal class Vvod
    {
        public void vvod(TextBox textBox1, TextBox textBox2,TextBox textBox3)
        {

            using (StreamReader sr = new StreamReader("C:\\1\\11.txt"));
            {

                System.IO.StreamWriter writer = new System.IO.StreamWriter("C:\\1\\11.txt", true);
                writer.WriteLine(textBox1.Text);
                textBox1.Text = "";
                writer.Close();
            }
            using (StreamReader sr = new StreamReader("C:\\1\\10.txt"));
            {
                System.IO.StreamWriter writer = new System.IO.StreamWriter("C:\\1\\10.txt", true);
                writer.WriteLine(textBox3.Text);
                writer.Close();
                textBox3.Text = "";

            }
            using (StreamReader sr = new StreamReader("C:\\1\\13.txt"));
            {
                System.IO.StreamWriter writer = new System.IO.StreamWriter("C:\\1\\13.txt", true);
                writer.WriteLine(textBox2.Text);
                writer.Close();
                textBox2.Text = "";
                MessageBox.Show("Контакт сохранен");

            }
        }
    }
}
