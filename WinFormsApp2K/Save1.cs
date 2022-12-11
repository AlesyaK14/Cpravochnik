using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp2K
{
    internal class Save1
    {
        public void Saving(ListBox listBox1)
        {
            List<string> lines = File.ReadLines(@"C:\\1\\14.txt").ToList();
            List<string> lines1 = File.ReadLines(@"C:\\1\\15.txt").ToList();
            List<string> lines2 = File.ReadLines(@"C:\\1\\16.txt").ToList();
            List<string> lines3 = File.ReadLines(@"C:\\1\\17.txt").ToList();
            lines.Add("");
            lines1.Add("");
            lines2.Add("");
            lines3.Add("");
            lines.RemoveAt(listBox1.SelectedIndex);
            lines1.RemoveAt(listBox1.SelectedIndex);
            lines2.RemoveAt(listBox1.SelectedIndex);
            lines3.RemoveAt(listBox1.SelectedIndex);
            // удалить выбранную строку
            File.WriteAllText(@"C:\\1\\14.txt", string.Join(Environment.NewLine, lines));
            File.WriteAllText(@"C:\\1\\15.txt", string.Join(Environment.NewLine, lines1));
            File.WriteAllText(@"C:\\1\\16.txt", string.Join(Environment.NewLine, lines2));
            File.WriteAllText(@"C:\\1\\17.txt", string.Join(Environment.NewLine, lines3));
            listBox1.ClearSelected();
            listBox1.Items.Clear();

            StreamReader streamReader = new StreamReader("C:\\1\\17.txt");
            //Открываем файл для чтения
            string str = "";
            //Объявляем переменную, в которую будем записывать текст из файла

            while (!streamReader.EndOfStream)
            //Цикл длится пока не будет достигнут конец файла
            {
                str = streamReader.ReadLine();
                //В переменную str построчно записываем содержимое файла
                listBox1.Items.Add(str);
            }
            streamReader.Close();
        }
    }
}
