using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;

namespace PhoneAppTabControl
{
    public partial class PivotPage1 : PhoneApplicationPage
    {
        public PivotPage1()
        {
            InitializeComponent();
        }

        private void PhoneApplicationPage_Loaded(object sender, RoutedEventArgs e)
        {
            pivot.SelectedIndex = 0;
        }

        private void bt1_Click(object sender, RoutedEventArgs e)
        {
            pivot.SelectedIndex = 0;
        }

        private void bt2_Click(object sender, RoutedEventArgs e)
        {
            pivot.SelectedIndex = 1;
        }

        private void bt3_Click(object sender, RoutedEventArgs e)
        {
            pivot.SelectedIndex = 2;
        }

        private void bt4_Click(object sender, RoutedEventArgs e)
        {
            pivot.SelectedIndex = 3;
        }

        private void bt5_Click(object sender, RoutedEventArgs e)
        {
            pivot.SelectedIndex = 4;
        }

        private void pivot_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string stateName = String.Format("VisualState{0}", pivot.SelectedIndex+1);
            VisualStateManager.GoToState(this, stateName, true);
        }
    }
}