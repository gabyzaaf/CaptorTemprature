using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp_Projet
{
    public class Grandeur
    {
        public string nom { get; set; }
        public string unite { get; set; }
        public string abreviation { get; set; }
        public LinkedList<Detail> listeDetail { get; set; }


        public Grandeur(string nom, string unite, string abreviation)
        {
            this.nom = nom;
            this.unite = unite;
            this.abreviation = abreviation;
        }
    }
}
