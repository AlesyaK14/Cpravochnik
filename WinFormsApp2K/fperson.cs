using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp2K;

namespace WinFormsApp2K
{
    internal class fperson : person
    {
        public string number;
        public string email;
        public fperson(string name,string number, string email) : base(name)
        {
            this.number=number;
            this.email = email;
        }
    }
}
