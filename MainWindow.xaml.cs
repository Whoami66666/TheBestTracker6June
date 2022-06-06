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
using TheBestTracker.CategoryStuff;
using TheBestTracker.UserInterface;

namespace TheBestTracker
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            SettingsWindow settingsWindow = new SettingsWindow();
            settingsWindow.Show();
            //SeeTheWeek adminWindow = new SeeTheWeek();
            //adminWindow.Show();
            this.Close();
        }


    }
}
