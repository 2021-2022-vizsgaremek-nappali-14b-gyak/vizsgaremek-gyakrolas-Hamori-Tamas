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


namespace Vizsgaremek.Pages
{
    /// <summary>
    /// Interaction logic for ProgramVersion.xaml
    /// </summary>
    public partial class ProgramVersion : UserControl
    {
        public ProgramVersion()
        {
            InitializeComponent();
        }

        // Vissza ikonon kattintva visszatér a nyitóoldalra
        private void Image_PreviewMouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            WelcomePage welcomePage = new WelcomePage();
            Navigate.Navigation(welcomePage);
        }
    }
}
