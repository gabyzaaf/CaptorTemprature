using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OxyPlot.Annotations;
using OxyPlot;

namespace Tp_Projet.ViewModels
{
    class MainWindowModel : INotifyPropertyChanged
    {
        /*
        public event PropertyChangedEventHandler PropertyChanged;

        private PlotModel plotmodel;
        public PlotModel plotmodel{
            
            }
        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null) handler(this, new PropertyChangedEventArgs(propertyName));


        }
        */
        public event PropertyChangedEventHandler PropertyChanged;
    }
}
