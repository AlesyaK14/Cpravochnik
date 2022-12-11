using System.Collections.Generic;
using System.Windows.Forms;

namespace WinFormsApp2K
    
{
    public partial class Form1 : Form
    {
        static List<fperson> l = new List<fperson>();
        // глобальная переменная
        person person = new person(l);
        public Form1()
        {
            InitializeComponent();
        }
        private void button7_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader("C:\\1\\11.txt");
            StreamReader sr1 = new StreamReader("C:\\1\\10.txt");
            StreamReader sr2 = new StreamReader("C:\\1\\13.txt");
            string m;
            string m1;
            string m2;
            while ((m = sr.ReadLine()) != null && (m1 = sr1.ReadLine()) != null && (m2 = sr2.ReadLine()) != null)
            {
                fperson A = new fperson("", "", "");
                A.name = m;
                A.email = m1;
                A.number = m2;
                l.Add(A);
            }
            sr.Close();
            sr1.Close();
            sr2.Close();
            StreamReader read = new StreamReader("C:\\1\\11.txt");
            foreach (string str in read.ReadToEnd().Split(new Char[] { ' ', '\r' }))
            {
                listBox1.Items.Add(str);
            }
            read.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Form2 s = new Form2();
            s.Show();
        }
        Save save = new Save();
        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                save.Saving(listBox1);
            }
            catch
            {
                MessageBox.Show("возникла ошибка");
            }
        }
        private void button3_Click_1(object sender, EventArgs e)
        {
            string s = textBox1.Text;
            string s1 = textBox2.Text;
            string s2 = textBox3.Text;
            int x = person.ind(s, s1, s2);
            if (x != -1)
            {
                textBox2.Text = l[x].number;
                textBox3.Text = l[x].email;
            }
            else
                MessageBox.Show("Контакт не найден");
        }
        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
        }
    }
}