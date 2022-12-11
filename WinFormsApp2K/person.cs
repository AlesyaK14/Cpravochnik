using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp2K
{
    interface p
    {
        public int ind(string s, string s1, string s2);
    }
    internal class person:p
    {
        public string name;
        public person(string name)
        {
            this.name = name;
        }
        public person(List<fperson> l)
        {
            this.l = l;
        }
        public person()
        {

        }
        public List<fperson> l;
        public int ind(string s, string s1, string s2)
        {
            for (int i = 0; i < l.Count; i++)
            {
                if (l[i].name.Equals(s))
                    return i;
            }
            for (int i = 0; i < l.Count; i++)
            {
                if (l[i].number.Equals(s1))
                    return i;
            }
            for (int i = 0; i < l.Count; i++)
            {
                if (l[i].email.Equals(s2))
                    return i;
            }
            return -1;
        }
        List<Adress> adress = new List<Adress>();
        public int ind1(string s,string s1, string s2,string s3)
        { 
            for (int i = 0; i < adress.Count; i++)
            {
                if (adress[i].city.Equals(s))
                    return i;
            }
            for (int i = 0; i < adress.Count; i++)
            {
                if (adress[i].yl.Equals(s1))
                    return i;
            }
            for (int i = 0; i < adress.Count; i++)
            {
                if (adress[i].home.Equals(s2))
                    return i;
            }
            for (int i = 0; i < adress.Count; i++)
            {
                if (adress[i].name.Equals(s3))
                    return i;
            }
            return -1;

        }
    }
}
