using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Core;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

//Szablon elementu Pusta strona jest udokumentowany na stronie https://go.microsoft.com/fwlink/?LinkId=234238

namespace cookbook_ui
{
    /// <summary>
    /// Pusta strona, która może być używana samodzielnie lub do której można nawigować wewnątrz ramki.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            var currentView = SystemNavigationManager.GetForCurrentView();
            currentView.AppViewBackButtonVisibility = AppViewBackButtonVisibility.Visible;
            currentView.BackRequested += CurrentView_BackRequested;
            
            navigateToPage(typeof(HomePage));
        }

        private void CurrentView_BackRequested(object sender, BackRequestedEventArgs e)
        {
            if (Frame.CanGoBack)
                Frame.GoBack();
        }

        private void HomeRadioButton_Click(object sender, RoutedEventArgs e)
        {
            navigateToPage(typeof(HomePage));
        }

        private void HamburgerButton_Click(object sender, RoutedEventArgs e)
        {
            SplitView.IsPaneOpen = !SplitView.IsPaneOpen;
        }

        private void navigateToPage(Type pageType, object parameter = null)
        {
            if(Frame.Content?.GetType() != pageType)
            {
                Frame.Navigate(pageType, parameter);
            }
            SplitView.IsPaneOpen = false;
        }

        private void LoginRadioButton_Click(object sender, RoutedEventArgs e)
        {
            navigateToPage(typeof(LoginPage));
        }

        private void SearchRadioButton_Click(object sender, RoutedEventArgs e)
        {
            navigateToPage(typeof(SearchPage));
        }

        private void CategoriesRadioButton_Click(object sender, RoutedEventArgs e)
        {
            navigateToPage(typeof(CategoriesPage));
        }
    }
}
