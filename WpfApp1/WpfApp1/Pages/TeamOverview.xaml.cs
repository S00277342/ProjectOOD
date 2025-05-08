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
    /// Logique d'interaction pour Players.xaml
    /// </summary>
    public partial class TeamOverview : Page
    {
        PlayerDbContext db = new PlayerDbContext();
        public List<Player> Attackers { get; set; }
        public List<Player> Midfielders { get; set; }
        public List<Player> Defenders { get; set; }
        public List<Player> Goalkeepers { get; set; }
        public Coach Coach { get; set; }
        public TeamOverview()
        {
            InitializeComponent();

            using (db) 
            {
                List<Player> players = db.Players.ToList();
                Attackers = players
                    .Where(p => p.Position == "RW" || p.Position == "ST" ||  p.Position == "LW")
                    .OrderByDescending(p => p.MarketValue)
                    .ToList();
                Midfielders = players
                    .Where(p => p.Position == "CM" || p.Position == "CAM" || p.Position == "CDM")
                    .OrderByDescending(p => p.MarketValue)
                    .ToList();
                Defenders = players
                    .Where(p => p.Position == "LB" || p.Position == "CB" || p.Position == "RB")
                    .OrderByDescending(p => p.MarketValue)
                    .ToList();
                Goalkeepers = players
                    .Where(p => p.Position == "GK")
                    .OrderByDescending(p => p.MarketValue)
                    .ToList();
                Coach = db.Coachs.FirstOrDefault();
            }
            DataContext = this;
        }

        private void PlayersListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var listBox = sender as ListBox;

            if (listBox != null && listBox.SelectedItem != null)
            {
                Player selectedPlayer = (Player)listBox.SelectedItem;
                this.NavigationService.Navigate(new PlayerDetails(selectedPlayer));
            }
        }

        private void bt_team_Click(object sender, RoutedEventArgs e)
        {
            NavigationService?.Navigate(new Lineup());
        }

        private void bt_matches_Click(object sender, RoutedEventArgs e)
        {
            NavigationService?.Navigate(new Matches());
        }
    }
}
