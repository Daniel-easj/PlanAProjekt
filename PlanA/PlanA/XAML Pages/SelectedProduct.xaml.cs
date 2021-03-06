﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace PlanA.XAML_Pages
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class SelectedProduct : Page
    {
        public SelectedProduct()
        {
            this.InitializeComponent();
        }

        public void GoToInventoryMainPage(object sender, RoutedEventArgs a)
        {
            this.Frame.Navigate(typeof(InventoryMainPage), null);
        }

        public void GoToCustomerMainPage(object sender, RoutedEventArgs a)
        {
            this.Frame.Navigate(typeof(CustomerMainPage), null);
        }

        public void GoToStatisticPage(object sender, RoutedEventArgs a)
        {
            this.Frame.Navigate(typeof(StatisticPage), null);
        }

        private void GoToNewAssignment(object sender, RoutedEventArgs a)
        {
            this.Frame.Navigate(typeof(NewAssignment), null);
        }

        private void GoToMainPage(object sender, RoutedEventArgs a)
        {
            this.Frame.Navigate(typeof(MainPage), null);
        }

        private void GoToChooseCustomer(object sender, RoutedEventArgs a)
        {
            this.Frame.Navigate(typeof(ChooseCustomer), null);
        }

        private void GoToNewProduct(object sender, RoutedEventArgs a)
        {
            this.Frame.Navigate(typeof(NewPaint), null);
        }

        private void GoToTotalAssignmentOverview(object sender, RoutedEventArgs a)
        {
            this.Frame.Navigate(typeof(TotalAssignmentOverview), null);
        }
    }
}
