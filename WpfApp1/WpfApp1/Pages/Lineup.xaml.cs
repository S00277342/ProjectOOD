using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Navigation;
using WpfApp1;

namespace PSGPathToGlory.Pages
{
    public partial class Lineup : Page
    {
        PlayerDbContext db = new PlayerDbContext();
        public Player LW { get; set; }
        public Player ST { get; set; }
        public Player RW { get; set; }
        public Player CM { get; set; }
        public Player CDM { get; set; }
        public Player CAM { get; set; }
        public Player LB { get; set; }
        public Player CB1 { get; set; }
        public Player CB2 { get; set; }
        public Player RB { get; set; }
        public Player GK { get; set; }
        public List<Player> PrioritySubstitutes { get; set; }

        public Lineup()
        {
            InitializeComponent();

            using (db)
            {
                List<Player> players = db.Players.ToList();
                RW = GetStarter(players, "RW");
                LW = GetStarter(players, "LW");
                ST = GetStarter(players, "ST");
                CAM = GetStarter(players, "CAM");
                CM = GetStarter(players, "CM");
                CDM = GetStarter(players, "CDM");
                LB = GetStarter(players, "LB");
                CB1 = GetStarter(players, "CB", 0);
                CB2 = GetStarter(players, "CB", 1);
                RB = GetStarter(players, "RB");
                GK = GetStarter(players, "GK");
                PrioritySubstitutes = players
                    .Where(p => p.IsPrioritySubstitute)
                    .ToList();
            }

            DataContext = this;
        }

        private Player GetStarter(List<Player> players, string position, int index = 0)
        {
            return players
                .Where(p => p.IsStarter && p.Position == position)
                .Skip(index)
                .FirstOrDefault();
        }
        private void OnImageFailed(object sender, ExceptionRoutedEventArgs e)
        {
            MessageBox.Show(e.ErrorException.Message);
        }

        private void bt_tactic_Click(object sender, RoutedEventArgs e)
        {
            NavigationService?.Navigate(new TeamOverview());
        }

        private void bt_matches_Click(object sender, RoutedEventArgs e)
        {
            NavigationService?.Navigate(new Matches());
        }

        private void Image_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            NavigationService?.Navigate(new PlayerDetails(ST));
        }

        private void Image_MouseLeftButtonDown_1(object sender, MouseButtonEventArgs e)
        {
            NavigationService?.Navigate(new PlayerDetails(LW));
        }

        private void Image_MouseLeftButtonDown_2(object sender, MouseButtonEventArgs e)
        {
            NavigationService?.Navigate(new PlayerDetails(RW));
        }

        private void Image_MouseLeftButtonDown_3(object sender, MouseButtonEventArgs e)
        {
            NavigationService?.Navigate(new PlayerDetails(CM));
        }

        private void Image_MouseLeftButtonDown_4(object sender, MouseButtonEventArgs e)
        {
            NavigationService?.Navigate(new PlayerDetails(CAM));
        }

        private void Image_MouseLeftButtonDown_5(object sender, MouseButtonEventArgs e)
        {
            NavigationService?.Navigate(new PlayerDetails(CDM));
        }

        private void Image_MouseLeftButtonDown_6(object sender, MouseButtonEventArgs e)
        {
            NavigationService?.Navigate(new PlayerDetails(LB));
        }

        private void Image_MouseLeftButtonDown_7(object sender, MouseButtonEventArgs e)
        {
            NavigationService?.Navigate(new PlayerDetails(CB1));
        }

        private void Image_MouseLeftButtonDown_8(object sender, MouseButtonEventArgs e)
        {
            NavigationService?.Navigate(new PlayerDetails(CB2));
        }

        private void Image_MouseLeftButtonDown_9(object sender, MouseButtonEventArgs e)
        {
            NavigationService?.Navigate(new PlayerDetails(RB));
        }

        private void Image_MouseLeftButtonDown_10(object sender, MouseButtonEventArgs e)
        {
            NavigationService?.Navigate(new PlayerDetails(GK));
        }
    }
}