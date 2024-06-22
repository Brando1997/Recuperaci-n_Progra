﻿using System;
using System.Collections.Generic;
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

namespace Final
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataAcces dataAcces = new DataAcces();
            List<Alumno> alumnosConDapper = dataAcces.GetAllDapper();
            myDataGrid.ItemsSource = alumnosConDapper;
        }

        private void updateBtn_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
