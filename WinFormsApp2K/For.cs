using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsApp2K
{
    public partial class For : Form
    {
        public For()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
        Vvod1 Vvod1=new Vvod1();
        private void button2_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text == "") || (textBox2.Text == "") || (textBox3.Text == "") || (textBox4.Text == ""))
            {
                MessageBox.Show("Ошибка \n" + "Необходимо ввести данные",
                    "Адрессной справочник", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Vvod1.vvod(textBox1, textBox2, textBox3, textBox4);
            }
        }
        List<Adress> adress = new List<Adress>();
        private void For_Load(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader("C:\\1\\14.txt");
            StreamReader sr1 = new StreamReader("C:\\1\\15.txt");
            StreamReader sr2 = new StreamReader("C:\\1\\16.txt");
            StreamReader sr3 = new StreamReader("C:\\1\\17.txt");
            string m;
            string m1;
            string m2;
            string m3;
            while ((m = sr.ReadLine()) != null && (m1 = sr1.ReadLine()) != null && (m2 = sr2.ReadLine()) != null && (m3 = sr3.ReadLine()) != null)
            {
                Adress A = new Adress("", "", "","");
                A.name = m3;
                A.city = m;
                A.home = m2;
                A.yl = m1;
                adress.Add(A);
            }
            sr.Close();
            sr1.Close();
            sr2.Close();
            sr3.Close();
            StreamReader read = new StreamReader("C:\\1\\17.txt");
            foreach (string str in read.ReadToEnd().Split(new Char[] { ' ', '\r' }))
            {
                listBox1.Items.Add(str);
            }
            read.Close();
        }
        Save1 save1 = new Save1();
        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                save1.Saving(listBox1);
            }
            catch
            {
                MessageBox.Show("возникла ошибка");
            }
        }
        person person = new person();
        private void button3_Click(object sender, EventArgs e)
        {
            string s = textBox1.Text;
            string s1 = textBox2.Text;
            string s2 = textBox3.Text;
            string s3 = textBox4.Text;
            int x = person.ind1(s, s1, s2,s3);
            if (x != -1)
            {
                textBox1.Text = adress[x].city;
                textBox2.Text = adress[x].yl;
                textBox3.Text = adress[x].home;
            }
            else
                MessageBox.Show("Адресс не найден");
        }
        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox3.Text = "";
            textBox2.Text = "";
            textBox4.Text = "";
        }
    }
}
