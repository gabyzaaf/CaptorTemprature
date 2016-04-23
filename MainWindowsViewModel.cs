using OxyPlot;
using OxyPlot.Axes;
using OxyPlot.Series;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp_Projet
{
    public class MainWindowsViewModel
    {

        public PlotModel GraphModel { get; set; }
        public MainWindowsViewModel()
        {
            GraphModel = new PlotModel();
            SetGraphAxesAndTitle();
            GenerateData();
            GraphModel.InvalidatePlot(true); // Notifie au PlotView de reconstruire le graphique
        }

        private void SetGraphAxesAndTitle()
        {
            GraphModel.Title = "Exemple graphique"; // Titre du graphique
            //////////Génération Axe X//////////
            LinearAxis abscisse = new LinearAxis();
            abscisse.Title = "Jours";
            abscisse.Position = AxisPosition.Bottom;
            //////////Génération Axe Y//////////
            LinearAxis ordonnee = new LinearAxis();
            ordonnee.Title = "Temperature";
            ordonnee.Position = AxisPosition.Left;
            //////////Ajout des axes au PlotModel//////////
            GraphModel.Axes.Add(abscisse);
            GraphModel.Axes.Add(ordonnee);
        }

        private void GenerateData()
        {
            Random rndGenerator = new Random();
            LineSeries donnees = new LineSeries(); //Conteneur de la série de points
            //Génération de 50 points avec abscisse régulière et ordonnée aléatoire
            for (int abscisse = 0; abscisse < 50; abscisse++)
            {
                donnees.Points.Add(new DataPoint(abscisse, rndGenerator.Next(0, 100)));
            }
            GraphModel.Series.Add(donnees); // Ajout de la série de points au PlotModel
        }
    }
}
