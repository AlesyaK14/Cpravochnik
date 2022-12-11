using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WinFormsApp2K
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        Vvod Vvod = new Vvod();
        private void button1_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text == "") || (textBox2.Text == ""))
            {
                MessageBox.Show("Ошибка \n" + "Необходимо ввести данные хотябы в два поля",
                    "Телефонный справочник", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Vvod.vvod(textBox1,textBox2,textBox3);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox3.Text = "";
            textBox2.Text = "";
        }
    }
}
