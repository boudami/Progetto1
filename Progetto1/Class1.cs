using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Progetto1
{
    internal class Class1
    {    
    }
    public class Brano
    {
        string titolo, autore;
        int durata;
        public Brano(string titolo, string autore, int durata)
        {
            this.titolo = titolo;
            this.autore = autore;
            this.durata = durata;
        }
        public string getTitolo()
        {
            return titolo;
        }
        public string getAutore()
        {
            return autore;
        }
        public int getDurata()
        {
            return durata;
        }
        //public Brano(string v)
        //{
        //    V = v;
        //}

        //Brano b= new Brano("");

        //public string V { get; }

    }
}
