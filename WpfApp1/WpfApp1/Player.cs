using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace WpfApp1
{
    public class Player
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string PhotoPath { get; set; }
        public string Age { get; set; }
        public string Position { get; set; }
        public bool IsStarter { get; set; }
        public bool IsPrioritySubstitute { get; set; }
        public string Qualities { get; set; }
        public string Height { get; set; }
        public string Nationality { get; set; }
        public string StrongFoot { get; set; }
        public string Number { get; set; }
        public string MarketValue { get; set; }
    }

    public class Coach
    {
        public int Id { get; set; }
        public string PhotoPath { get; set; }
        public string Name { get; set; }
        public string Age { get; set; }
        public string Past_Teams { get; set; }
        public string Strategy { get; set; }
    }

    public class ICMatch 
    {
        public int Id { get; set; }
        public string Team { get; set; }
        public string Stadium { get; set; }
        public string Competition { get; set; }
        public string Date { get; set; }
        public string TeamPhotoPath { get; set; }
        public string Win {  get; set; }
        public string Lose { get; set; }
        public string Draw {  get; set; }
    }

    public class Match
    {
        public int Id { get; set; }
        public string Team { get; set; }
        public string TeamPhotoPath { get; set; }
        public string Stadium { get; set; }
        public string Competition { get; set; }
        public string FinalScore { get; set; }
        public string Date { get; set; }
        public string Possession1 { get; set; }
        public string Possession2 { get; set; }
        public string XGoals1 { get; set; }
        public string XGoals2 { get; set; }
        public virtual Player PlayerOfTheMatch { get; set; }
        public string AverageRating1 { get; set; }
        public string AverageRating2 { get; set; }
        public string BigChances1 { get; set; }
        public string BigChances2 { get; set; }
        public string TotalShots1 { get; set; }
        public string TotalShots2 { get; set; }
        public string GoalkeeperSaves1 { get; set; }
        public string GoalkeeperSaves2 { get; set; }
        public string CornerKicks1 { get; set; }
        public string CornerKicks2 { get; set; }
        public string Tackles1 { get; set; }
        public string Tackles2 { get; set; }
        public string Fouls1 { get; set; }
        public string Fouls2 { get; set; }
        public string FreeKicks1 { get; set; }
        public string FreeKicks2 { get; set; }
        public string Score { get; set; }
        public virtual List<Player> StartingXI { get; set; }
        public virtual List<Player> Bench {  get; set; }
    }

    public class MatchDetailViewModel
    {
        public Match SelectedMatch { get; set; }

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

        public MatchDetailViewModel(Match match)
        {
            SelectedMatch = match;
            List<Player> players = match.StartingXI;
            List<Player> substitutes = match.Bench;
            LW = GetStarter(players, "LW");
            RW = GetStarter(players, "RW");
            ST = GetStarter(players, "ST");
            CAM = GetStarter(players, "CAM");
            CM = GetStarter(players, "CM");
            CDM = GetStarter(players, "CDM");
            LB = GetStarter(players, "LB");
            CB1 = GetStarter(players, "CB", 0);
            CB2 = GetStarter(players, "CB", 1);
            RB = GetStarter(players, "RB");
            GK = GetStarter(players, "GK");
            PrioritySubstitutes = substitutes;
        }

        private Player GetStarter(List<Player> players, string position, int index = 0)
        {
            return players
                .Where(p => p.Position == position)
                .Skip(index)
                .FirstOrDefault();
        }
    }


    public class PlayerDbContext : DbContext
    {
        public PlayerDbContext() : base("Database") { }
        public DbSet<Player> Players { get; set; }
        public DbSet<Coach> Coachs { get; set; }
        public DbSet<Match> Matches { get; set; }
        public DbSet<ICMatch> ICMatches { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
           
            modelBuilder.Entity<Match>()
                .HasMany(m => m.StartingXI)
                .WithMany()
                .Map(cs =>
                {
                    cs.MapLeftKey("MatchId");
                    cs.MapRightKey("PlayerId");
                    cs.ToTable("MatchStartingXI");
                });

            modelBuilder.Entity<Match>()
                .HasMany(m => m.Bench)
                .WithMany()
                .Map(cs =>
                {
                    cs.MapLeftKey("MatchId");
                    cs.MapRightKey("PlayerId");
                    cs.ToTable("MatchBench");
                });

            base.OnModelCreating(modelBuilder);
        }
    }



}
