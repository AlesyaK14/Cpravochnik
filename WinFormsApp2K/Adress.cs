using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp2K
{
    internal class Adress:person
    {
        public string city;
        public string yl;
        public string home;
        public Adress(string name, string city, string yl,string home) : base(name)
        {
            this.home = home;
            this.city = city;
            this.yl = yl;
        }
    }
}
