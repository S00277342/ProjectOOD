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
    /// Logique d'interaction pour ICMatchDetailPage.xaml
    /// </summary>
    public partial class ICMatchDetailPage : Page
    {
        public ICMatchDetailPage(ICMatch selectedMatch)
        {
            InitializeComponent();
            DataContext = selectedMatch;
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

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            if (NavigationService.CanGoBack)
            {
                NavigationService.GoBack();
            }
        }
    }
}
