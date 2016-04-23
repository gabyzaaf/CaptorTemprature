﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;


namespace Tp_Projet
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
      

        public MainWindow()
        {

            FileManagement files = new FileManagement();
            files.ReadFile();

            this.DataContext = new MainWindowsViewModel();
           
            InitializeComponent();
        }
    


    private void button_Click(object sender, RoutedEventArgs e)
        {
          
          
        }
    }
}
