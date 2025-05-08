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
using System.Windows.Shapes;
using WpfApp1;

namespace PSGPathToGlory.Pages
{
    /// <summary>
    /// Logique d'interaction pour Matches.xaml
    /// </summary>
    public partial class Matches : Page
    {
        PlayerDbContext db = new PlayerDbContext();
        public Matches()
        {
            InitializeComponent();
            List<Match> matches = db.Matches.ToList();
            List<ICMatch> iCMatches = db.ICMatches.ToList();
            IncomingMatchesListBox.ItemsSource = iCMatches;
            MatchReviewListBox.ItemsSource = matches;
        }

        private void MatchReviewListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (MatchReviewListBox.SelectedItem is Match selectedMatch)
            {
                NavigationService.Navigate(new MatchDetailPage(selectedMatch));
            }
        }

        private void ICMatchReviewListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (IncomingMatchesListBox.SelectedItem is ICMatch selectedMatch)
            {
                NavigationService.Navigate(new ICMatchDetailPage(selectedMatch));
            }
        }

        private void bt_team_Click(object sender, RoutedEventArgs e)
        {
            NavigationService?.Navigate(new Lineup());
        }

        private void bt_players_Click(object sender, RoutedEventArgs e)
        {
            NavigationService?.Navigate(new TeamOverview());
        }
    }
}
