using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp_Projet
{
   public class Capteur
    {
        public string id { get; set; }
        public string description { get; set; }
        public Grandeur grandeur { get; set; }

        public string box { get; set; }
        public string lieu { get; set; }
        public LinkedList<Detail> listeDetail { get; set; }

        public Capteur(string id, string description, string nom, string unite, string abrevation, string box, string lieu)
        {
            this.id = id;
            this.description = description;
            grandeur = new Grandeur(nom, unite, abrevation);
            this.box = box;
            this.lieu = lieu;
        }
        public override string ToString()
        {
            return "id : " + this.id + " description : " + this.description + " nom =  " + grandeur.nom + " " + grandeur.unite + " " + grandeur.unite + " " + grandeur.abreviation + " " + box + " " + lieu;

        }
    }
}
