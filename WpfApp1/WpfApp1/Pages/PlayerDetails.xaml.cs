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
    /// Logique d'interaction pour PlayerDetails.xaml
    /// </summary>
    public partial class PlayerDetails : Page
    {
        private Player CurrentPlayer;
        public PlayerDetails(Player SelectedPlayer)
        {
            InitializeComponent();
            CurrentPlayer = SelectedPlayer;
            tbx_Name.Text = CurrentPlayer.Name;
            tbx_Pos.Text = CurrentPlayer.Position;
            tbx_Height.Text = CurrentPlayer.Height;
            tbx_Natio.Text = CurrentPlayer.Nationality;
            tbx_Foot.Text = CurrentPlayer.StrongFoot;
            tbx_Num.Text = CurrentPlayer.Number;
            tbx_Value.Text = CurrentPlayer.MarketValue;
            tbx_Age.Text = CurrentPlayer.Age;
            tbx_qual.Text = CurrentPlayer.Qualities;
            img.Source = new BitmapImage(new Uri(CurrentPlayer.PhotoPath, UriKind.RelativeOrAbsolute));
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
