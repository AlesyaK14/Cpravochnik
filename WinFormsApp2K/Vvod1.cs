using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp2K
{
    internal class Vvod1
    {
        public void vvod(TextBox textBox1, TextBox textBox2, TextBox textBox3,TextBox textBox4)
        {
            using (StreamReader sr = new StreamReader("C:\\1\\14.txt")) ;
            {

                System.IO.StreamWriter writer = new System.IO.StreamWriter("C:\\1\\14.txt", true);
                writer.WriteLine(textBox1.Text);
                textBox1.Text = "";
                writer.Close();
            }
            using (StreamReader sr = new StreamReader("C:\\1\\15.txt")) ;
            {
                System.IO.StreamWriter writer = new System.IO.StreamWriter("C:\\1\\15.txt", true);
                writer.WriteLine(textBox2.Text);
                writer.Close();
                textBox2.Text = "";

            }
            using (StreamReader sr = new StreamReader("C:\\1\\16.txt")) ;
            {
                System.IO.StreamWriter writer = new System.IO.StreamWriter("C:\\1\\16.txt", true);
                writer.WriteLine(textBox3.Text);
                writer.Close();
                textBox3.Text = "";
            }
            using (StreamReader sr = new StreamReader("C:\\1\\17.txt")) ;
            {

                System.IO.StreamWriter writer = new System.IO.StreamWriter("C:\\1\\17.txt", true);
                writer.WriteLine(textBox4.Text);
                textBox4.Text = "";
                writer.Close();
                MessageBox.Show("Информация сохранена");
            }
        }
    }
}
