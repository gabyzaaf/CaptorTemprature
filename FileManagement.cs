using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Tp_Projet
{
    class FileManagement
    {
        LinkedList<Capteur> listCapteur = new LinkedList<Capteur>();

        public void executeList()
        {
            foreach (Capteur cap in listCapteur)
            {

                Console.WriteLine(cap.ToString());

            }


        }

        public void ReadFileDetail(string id)
        {
            StreamReader fichier = null;
            try
            {
                string[] listeFichier = Directory.GetFiles(@"C:\Users\gabriel\Desktop\SmartHome - Datas\ecole\netatmo\");
                string ligne;
                for (int i = 0; i < listeFichier.Length; i++)
                {
                     fichier = new StreamReader(listeFichier[i]);
                    while ((ligne = fichier.ReadLine()) != null)
                    {
                        string[] detailLigne = ligne.Split(" ");

                    }
                }

            }
            catch (IOException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                fichier.Close();
            }
           


        }

        public void ReadFile()
        {

            try
            {
                //Load xml
                System.Xml.Linq.XDocument xdoc = XDocument.Load(@"C:\Users\gabriel\Desktop\SmartHome - Datas\ecole\capteurs.xtim");

                xdoc.Descendants("capteur").Where(p => p.Element("box").Value.Equals("netatmo")).Select(
                    p => new
                    {
                        id = p.Element("id").Value,
                        description = p.Element("description").Value,
                        nom = p.Element("grandeur").Attribute("nom").Value,

                        unite = p.Element("grandeur").Attribute("unite").Value,

                        abreviation = p.Element("grandeur").Attribute("abreviation").Value,


                        box = p.Element("box").Value,
                        lieu = p.Element("lieu").Value

                    }).ToList().ForEach(p =>
                    {

                        listCapteur.AddLast(new Capteur(p.id, p.description, p.nom, p.unite, p.abreviation, p.box, p.lieu));

                    });
                ;

            }
            catch (Exception e)
            {

                Console.WriteLine("the error is " + e.Message);
                Console.ReadLine();
            }


        }
    }
}
