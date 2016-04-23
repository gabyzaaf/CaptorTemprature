using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp_Projet
{
    public class Detail
    {
        public  DateTime dateHeure { get; set; }
        public string id { get; set; }
        public float valeur { get; set; }

        public Detail(DateTime date_heure,string id_v,float valeur_v)
        {
            dateHeure = date_heure;
            id = id_v;
            valeur = valeur_v;
        }

    }
}
