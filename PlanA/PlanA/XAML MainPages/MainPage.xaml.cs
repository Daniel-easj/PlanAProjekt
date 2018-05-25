using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.ViewManagement;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using PlanA.XAML_MainPages;
using PlanA.XAML_Pages;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace PlanA
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        


        //private void AutoSuggestBox_TextChanged(AutoSuggestBox sender, AutoSuggestBoxTextChangedEventArgs args)
        //{
        //    if (args.Reason == AutoSuggestBoxTextChangedReason.UserInput)
        //    {
        //        sender.ItemsSource = //TODO
        //    }
        //}

        //private void AutoSuggestBox_SuggestionChosen(AutoSuggestBox sender,
        //    AutoSuggestBoxSuggestionChosenEventArgs args)
        //{
        //    sender.Text //TODO
        //}

        //private void AutoSuggestBox_QuerySubmitted(AutoSuggestBox sender, AutoSuggestBoxQuerySubmittedEventArgs args)
        //{
        //    if (args.ChosenSuggestion != null)
        //    {
        //        //TODO
        //    }
        //    else
        //    {
        //        //TODO
        //    }
        //}

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

        private void GoToLoadAndSaveMainPage(object sender, RoutedEventArgs a)
        {
            this.Frame.Navigate(typeof(LoadAndSaveMainPage), null);
        }

        
    }
}
