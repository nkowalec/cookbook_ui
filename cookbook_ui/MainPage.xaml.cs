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
using Windows.UI.Popups;

//Szablon elementu Pusta strona jest udokumentowany na stronie https://go.microsoft.com/fwlink/?LinkId=234238

namespace cookbook_ui
{
    /// <summary>
    /// Pusta strona, która może być używana samodzielnie lub do której można nawigować wewnątrz ramki.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        private static bool _zalogowany = false;
        public static bool Zalogowany
        {
            get { return _zalogowany; }
            set
            {
                _zalogowany = value;
                if (value)
                {
                    _loginRadioBtn.Content = "Wyloguj";
                    _accountRadioBtn.Visibility = Visibility.Visible;
                }
                else
                {
                    _loginRadioBtn.Content = "Zaloguj";
                    _accountRadioBtn.Visibility = Visibility.Collapsed;
                }
            }
        }

        public static void PokazujKomendy(bool opcja)
        {
            foreach(var item in _commandList)
            {
                item.Visibility = opcja ? Visibility.Visible : Visibility.Collapsed;
            }
        }

        private static RadioButton _loginRadioBtn;
        private static RadioButton _accountRadioBtn;
        private static List<Control> _commandList;

        public MainPage()
        {
            this.InitializeComponent();
            var currentView = SystemNavigationManager.GetForCurrentView();
            currentView.AppViewBackButtonVisibility = AppViewBackButtonVisibility.Visible;
            currentView.BackRequested += CurrentView_BackRequested;
            _loginRadioBtn = LoginRadioButton;
            _accountRadioBtn = AccountRadioButton;
            _commandList = new List<Control>();
            foreach(var item in commbar.PrimaryCommands)
            {
                _commandList.Add((Control)item);
            }
            foreach (var item in commbar.SecondaryCommands)
            {
                _commandList.Add((Control)item);
            }
            Frame.Navigating += Frame_Navigating;
            navigateToPage(typeof(HomePage));
        }

        private void Frame_Navigating(object sender, NavigatingCancelEventArgs e)
        {
            PokazujKomendy(false);
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
            if (Zalogowany)
            {
                Zalogowany = !Zalogowany;
                navigateToPage(typeof(HomePage));
            }
            else
            {
                navigateToPage(typeof(LoginPage));
            }
        }

        private void SearchRadioButton_Click(object sender, RoutedEventArgs e)
        {
            navigateToPage(typeof(SearchPage));
        }

        private void CategoriesRadioButton_Click(object sender, RoutedEventArgs e)
        {
            navigateToPage(typeof(CategoriesPage));
        }

        private void AccountRadioButton_Click(object sender, RoutedEventArgs e)
        {
            navigateToPage(typeof(AccountPage));
        }

        private async void AppBarButton_Click(object sender, RoutedEventArgs e)
        {
            await new MessageDialog("Polubienie przepisu").ShowAsync();
        }

        private async void AppBarButton_Click_1(object sender, RoutedEventArgs e)
        {
            await new MessageDialog("Ujemny głos dla przepisu").ShowAsync();
        }

        private async void AppBarButton_Click_2(object sender, RoutedEventArgs e)
        {
            await new MessageDialog("Dodanie komentarza dla dodającego przepis").ShowAsync();
        }

        private async void AppBarButton_Click_3(object sender, RoutedEventArgs e)
        {
            await new MessageDialog("Poleć znajomemu").ShowAsync();
        }
    }
}
