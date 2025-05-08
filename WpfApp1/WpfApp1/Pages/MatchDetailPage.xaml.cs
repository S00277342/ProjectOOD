using System;
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
using WpfApp1;

namespace PSGPathToGlory.Pages
{
    /// <summary>
    /// Logique d'interaction pour MatchDetailPage.xaml
    /// </summary>
    public partial class MatchDetailPage : Page
    {
        MatchDetailViewModel currentMatch {  get; set; }
        public MatchDetailPage(Match selectedMatch)
        {
            InitializeComponent();
            currentMatch = new MatchDetailViewModel(selectedMatch);
            DataContext = currentMatch;

        }

        private void OnImageFailed(object sender, ExceptionRoutedEventArgs e)
        {
            MessageBox.Show(e.ErrorException.Message);
        }

        private void bt_players_Click(object sender, RoutedEventArgs e)
        {
            NavigationService?.Navigate(new TeamOverview());
        }

        private void bt_team_Click(object sender, RoutedEventArgs e)
        {
            NavigationService?.Navigate(new Lineup());
        }

        private void bt_matches_Click(object sender, RoutedEventArgs e)
        {
            NavigationService?.Navigate(new Matches());
        }

        private void Image_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            NavigationService?.Navigate(new PlayerDetails(currentMatch.ST));
        }

        private void Image_MouseLeftButtonDown_1(object sender, MouseButtonEventArgs e)
        {
            NavigationService?.Navigate(new PlayerDetails(currentMatch.LW));
        }

        private void Image_MouseLeftButtonDown_2(object sender, MouseButtonEventArgs e)
        {
            NavigationService?.Navigate(new PlayerDetails(currentMatch.RW));
        }

        private void Image_MouseLeftButtonDown_3(object sender, MouseButtonEventArgs e)
        {
            NavigationService?.Navigate(new PlayerDetails(currentMatch.CM));
        }

        private void Image_MouseLeftButtonDown_4(object sender, MouseButtonEventArgs e)
        {
            NavigationService?.Navigate(new PlayerDetails(currentMatch.CAM));
        }

        private void Image_MouseLeftButtonDown_5(object sender, MouseButtonEventArgs e)
        {
            NavigationService?.Navigate(new PlayerDetails(currentMatch.CDM));
        }

        private void Image_MouseLeftButtonDown_6(object sender, MouseButtonEventArgs e)
        {
            NavigationService?.Navigate(new PlayerDetails(currentMatch.LB));
        }

        private void Image_MouseLeftButtonDown_7(object sender, MouseButtonEventArgs e)
        {
            NavigationService?.Navigate(new PlayerDetails(currentMatch.CB1));
        }

        private void Image_MouseLeftButtonDown_8(object sender, MouseButtonEventArgs e)
        {
            NavigationService?.Navigate(new PlayerDetails(currentMatch.CB2));
        }

        private void Image_MouseLeftButtonDown_9(object sender, MouseButtonEventArgs e)
        {
            NavigationService?.Navigate(new PlayerDetails(currentMatch.RB));
        }

        private void Image_MouseLeftButtonDown_10(object sender, MouseButtonEventArgs e)
        {
            NavigationService?.Navigate(new PlayerDetails(currentMatch.GK));
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            if (NavigationService.CanGoBack)
            {
                NavigationService.GoBack();
            }
        }
    }
}
