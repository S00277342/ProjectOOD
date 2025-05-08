using PSGPathToGlory.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp1;

namespace Database
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PlayerDbContext db = new PlayerDbContext();

            using (db) 
            {

                Player Donnaruma = new Player { Id = 1, Name = "Gianluigi Donnarumma", PhotoPath = "photos/donnarumma.jpg", Age = "25", Position = "GK", IsStarter = true, IsPrioritySubstitute = false, Qualities = "Reflexes, Shot Stopping", Height = "1.96", Nationality = "Italy", StrongFoot = "Right", Number = "99", MarketValue = "45M" };
                Player Tenas = new Player { Id = 2, Name = "Arnau Tenas", PhotoPath = "photos/arnau_tenas.jpg", Age = "22", Position = "GK", IsStarter = false, IsPrioritySubstitute = false, Qualities = "Distribution, Agility", Height = "1.85", Nationality = "Spain", StrongFoot = "Right", Number = "80", MarketValue = "5M" };
                Player Sofanov = new Player { Id = 3, Name = "Sergiy Sofanov", PhotoPath = "photos/sofanov.jpg", Age = "20", Position = "GK", IsStarter = false, IsPrioritySubstitute = true, Qualities = "Reflexes, Youth Potential", Height = "1.90", Nationality = "Ukraine", StrongFoot = "Right", Number = "81", MarketValue = "1M" };
                Player Beraldo = new Player { Id = 4, Name = "Lucas Beraldo", PhotoPath = "photos/beraldo.jpg", Age = "21", Position = "CB", IsStarter = false, IsPrioritySubstitute = true, Qualities = "Marking, Passing", Height = "1.86", Nationality = "Brazil", StrongFoot = "Left", Number = "35", MarketValue = "20M" };
                Player Marquinhos = new Player { Id = 5, Name = "Marquinhos", PhotoPath = "photos/marquinhos.jpg", Age = "29", Position = "CB", IsStarter = true, IsPrioritySubstitute = false, Qualities = "Leadership, Interceptions", Height = "1.83", Nationality = "Brazil", StrongFoot = "Right", Number = "5", MarketValue = "50M" };
                Player Pacho = new Player { Id = 6, Name = "Willian Pacho", PhotoPath = "photos/pacho.jpg", Age = "23", Position = "CB", IsStarter = true, IsPrioritySubstitute = false, Qualities = "Strength, Tackling", Height = "1.86", Nationality = "Ecuador", StrongFoot = "Left", Number = "4", MarketValue = "25M" };
                Player Hernandez = new Player { Id = 7, Name = "Lucas Hernandez", PhotoPath = "photos/hernandez.jpg", Age = "28", Position = "CB", IsStarter = false, IsPrioritySubstitute = true, Qualities = "Aggression, Tackling", Height = "1.84", Nationality = "France", StrongFoot = "Left", Number = "21", MarketValue = "35M" };
                Player Hakimi = new Player { Id = 8, Name = "Achraf Hakimi", PhotoPath = "photos/hakimi.jpg", Age = "26", Position = "RB", IsStarter = true, IsPrioritySubstitute = false, Qualities = "Speed, Attacking Runs", Height = "1.81", Nationality = "Morocco", StrongFoot = "Right", Number = "2", MarketValue = "65M" };
                Player Mendes = new Player { Id = 9, Name = "Nuno Mendes", PhotoPath = "photos/mendes.jpg", Age = "22", Position = "LB", IsStarter = true, IsPrioritySubstitute = false, Qualities = "Speed, Crossing", Height = "1.76", Nationality = "Portugal", StrongFoot = "Left", Number = "25", MarketValue = "5M" };
                Player Lee = new Player { Id = 10, Name = "Lee Kang-in", PhotoPath = "photos/lee.jpg", Age = "23", Position = "CAM", IsStarter = false, IsPrioritySubstitute = true, Qualities = "Dribbling, Creativity", Height = "1.73", Nationality = "South Korea", StrongFoot = "Left", Number = "19", MarketValue = "1M" };
                Player Warren = new Player { Id = 11, Name = "Warren Zaïre-Emery", PhotoPath = "photos/zaire_emery.jpg", Age = "18", Position = "CM", IsStarter = false, IsPrioritySubstitute = true, Qualities = "Passing, Vision", Height = "1.78", Nationality = "France", StrongFoot = "Right", Number = "33", MarketValue = "7M" };
                Player Mbaye = new Player { Id = 12, Name = "Ibrahim Mbaye", PhotoPath = "photos/mbaye.jpg", Age = "17", Position = "RW", IsStarter = false, IsPrioritySubstitute = false, Qualities = "Potential, Ball Control", Height = "1.85", Nationality = "France", StrongFoot = "Right", Number = "49", MarketValue = "2M" };
                Player Vitinha = new Player { Id = 13, Name = "Vitinha", PhotoPath = "photos/vitinha.jpg", Age = "24", Position = "CM", IsStarter = true, IsPrioritySubstitute = false, Qualities = "Passing, Movement", Height = "1.72", Nationality = "Portugal", StrongFoot = "Right", Number = "17", MarketValue = "60M" };
                Player Ruiz = new Player { Id = 14, Name = "Fabian Ruiz", PhotoPath = "photos/ruiz.jpg", Age = "28", Position = "CAM", IsStarter = true, IsPrioritySubstitute = false, Qualities = "Shooting, Composure", Height = "1.89", Nationality = "Spain", StrongFoot = "Left", Number = "8", MarketValue = "50M" };
                Player Neves = new Player { Id = 15, Name = "João Neves", PhotoPath = "photos/neves.jpg", Age = "19", Position = "CDM", IsStarter = true, IsPrioritySubstitute = false, Qualities = "Vision, Passing, Stamina", Height = "1.74", Nationality = "Portugal", StrongFoot = "Right", Number = "87", MarketValue = "65M" };
                Player Kvara = new Player { Id = 16, Name = "Khvicha Kvaratskhelia", PhotoPath = "photos/kvara.jpg", Age = "23", Position = "LW", IsStarter = true, IsPrioritySubstitute = false, Qualities = "Dribbling, Flair", Height = "1.83", Nationality = "Georgia", StrongFoot = "Right", Number = "7", MarketValue = "80M" };
                Player Barcola = new Player { Id = 17, Name = "Bradley Barcola", PhotoPath = "photos/barcola.jpg", Age = "21", Position = "LW", IsStarter = false, IsPrioritySubstitute = true, Qualities = "Dribbling, Acceleration", Height = "1.86", Nationality = "France", StrongFoot = "Right", Number = "29", MarketValue = "60M" };
                Player Dembele = new Player { Id = 18, Name = "Ousmane Dembélé", PhotoPath = "photos/dembele.jpg", Age = "27", Position = "ST", IsStarter = true, IsPrioritySubstitute = false, Qualities = "Two-footed, Speed", Height = "1.78", Nationality = "France", StrongFoot = "Both", Number = "10", MarketValue = "75M" };
                Player Ramos = new Player { Id = 19, Name = "Gonçalo Ramos", PhotoPath = "photos/ramos.jpg", Age = "23", Position = "ST", IsStarter = false, IsPrioritySubstitute = true, Qualities = "Finishing, Strength", Height = "1.85", Nationality = "Portugal", StrongFoot = "Right", Number = "9", MarketValue = "45M" };
                Player Doue = new Player { Id = 20, Name = "Desire Doue", PhotoPath = "photos/doue.jpg", Age = "19", Position = "RW", IsStarter = true, IsPrioritySubstitute = false, Qualities = "Dribbling, Creativity", Height = "1.81", Nationality = "France", StrongFoot = "Right", Number = "14", MarketValue = "60M" };
                Player mayulu = new Player { Id = 21, Name = "Joane Mayulu", PhotoPath = "photos/mayulu.jpg", Age = "18", Position = "ST", IsStarter = false, IsPrioritySubstitute = false, Qualities = "Finishing, Movement", Height = "1.80", Nationality = "France", StrongFoot = "Right", Number = "48", MarketValue = "1M" };
                Player Tape = new Player { Id = 22, Name = "Axel Tactouet Tape", PhotoPath = "photos/tape.jpg", Age = "17", Position = "RB", IsStarter = false, IsPrioritySubstitute = false, Qualities = "Speed, Defensive Awareness", Height = "1.78", Nationality = "France", StrongFoot = "Right", Number = "47", MarketValue = "0.5M" };
                Player Kamara = new Player { Id = 23, Name = "Noham Kamara", PhotoPath = "photos/kamara.jpg", Age = "17", Position = "CM", IsStarter = false, IsPrioritySubstitute = false, Qualities = "Passing, Vision", Height = "1.75", Nationality = "France", StrongFoot = "Right", Number = "46", MarketValue = "0.5M" };



                var _Coach = new Coach
                {
                    PhotoPath = "photos/enrique.jpg",
                    Name = "Luis Enrique",
                    Age = "53",
                    Past_Teams = "Barcelona, AS Roma, Celta Vigo",
                    Strategy = "High pressing and false 9 playstyle, where the central forward drops deep to create space and overloads. Focus on possession and constant attacking pressure."
                };

                Match match1 = new Match
                {
                    Id = 1,
                    Team = "Strasbourg",
                    TeamPhotoPath = "photos/strasbourg.jpg",
                    Stadium = "La Maineau",
                    Competition = "Ligue 1",
                    FinalScore = "1-2",
                    Date = "03/05/2025",
                    Possession1 = "64",
                    Possession2 = "36",
                    XGoals1 = "1.73",
                    XGoals2 = "0.73",
                    PlayerOfTheMatch = Barcola,
                    AverageRating1 = "7.5",
                    AverageRating2 = "6.2",
                    BigChances1 = "5",
                    BigChances2 = "1",
                    TotalShots1 = "18",
                    TotalShots2 = "7",
                    GoalkeeperSaves1 = "3",
                    GoalkeeperSaves2 = "6",
                    CornerKicks1 = "7",
                    CornerKicks2 = "2",
                    Tackles1 = "14",
                    Tackles2 = "18",
                    Fouls1 = "10",
                    Fouls2 = "12",
                    FreeKicks1 = "8",
                    FreeKicks2 = "6",
                    Score = "Barcola",
                    StartingXI = new List<Player> { Sofanov, Tape, Beraldo, Hernandez, Mendes, Warren, Neves, Lee, Barcola, Ramos, Mbaye },
                    Bench = new List<Player> { Kamara, Doue, Ruiz }
                };

                Match match2 = new Match
                {
                    Id = 2,
                    Team = "Arsenal",
                    TeamPhotoPath = "photos/arsenal.jpg",
                    Stadium = "Emirates Stadium",
                    Competition = "UEFA Champions League",
                    FinalScore = "1-0",
                    Date = "30/04/2025",
                    Possession1 = "58",
                    Possession2 = "42",
                    XGoals1 = "1.20",
                    XGoals2 = "0.52",
                    PlayerOfTheMatch = Vitinha,
                    AverageRating1 = "7.8",
                    AverageRating2 = "6.7",
                    BigChances1 = "4",
                    BigChances2 = "2",
                    TotalShots1 = "15",
                    TotalShots2 = "9",
                    GoalkeeperSaves1 = "4",
                    GoalkeeperSaves2 = "5",
                    CornerKicks1 = "6",
                    CornerKicks2 = "3",
                    Tackles1 = "16",
                    Tackles2 = "13",
                    Fouls1 = "9",
                    Fouls2 = "11",
                    FreeKicks1 = "7",
                    FreeKicks2 = "5",
                    Score = "Dembele",
                    StartingXI = new List<Player> { Donnaruma, Hakimi, Marquinhos, Pacho, Mendes, Neves, Vitinha, Ruiz, Kvara, Dembele, Doue },
                    Bench = new List<Player> { Barcola, Lee, Warren }
                };

                Match match3 = new Match
                {
                    Id = 3,
                    Team = "Le Havre",
                    TeamPhotoPath = "photos/havre.jpg",
                    Stadium = "Parc des Princes",
                    Competition = "Ligue 1",
                    FinalScore = "3-1",
                    Date = "19/04/2025",
                    Possession1 = "66",
                    Possession2 = "34",
                    XGoals1 = "2.85",
                    XGoals2 = "0.42",
                    PlayerOfTheMatch = Dembele,
                    AverageRating1 = "8.1",
                    AverageRating2 = "5.9",
                    BigChances1 = "6",
                    BigChances2 = "0",
                    TotalShots1 = "19",
                    TotalShots2 = "5",
                    GoalkeeperSaves1 = "2",
                    GoalkeeperSaves2 = "7",
                    CornerKicks1 = "8",
                    CornerKicks2 = "1",
                    Tackles1 = "12",
                    Tackles2 = "15",
                    Fouls1 = "8",
                    Fouls2 = "13",
                    FreeKicks1 = "6",
                    FreeKicks2 = "7",
                    Score = "Dembele Ramos Kvara",
                    StartingXI = new List<Player> { Donnaruma, Hakimi, Pacho, Marquinhos, Mendes, Neves, Vitinha, Ruiz, Kvara, Dembele, Mbaye },
                    Bench = new List<Player> { Barcola, Warren, Doue }
                };

                ICMatch icmatch1 = new ICMatch
                {
                    Id = 1,
                    Team = "Montpellier",
                    Stadium = "La Mosson",
                    Competition = "Ligue 1",
                    Date = "10/05/2025",
                    TeamPhotoPath = "photos/montpellier.png",
                    Win = "79%",
                    Lose = "8%",
                    Draw = "13%"
                };

                ICMatch icmatch2 = new ICMatch
                {
                    Id = 2,
                    Team = "Inter Milan",
                    Stadium = "Allianz Arena",
                    Competition = "UEFA Champions League",
                    Date = "31/05/2025",
                    TeamPhotoPath = "photos/inter.png",
                    Win = "52%",
                    Lose = "0%",
                    Draw = "48%"
                };

                db.Players.Add(Donnaruma);
                db.Players.Add(Tenas);
                db.Players.Add(Sofanov);
                db.Players.Add(Beraldo);
                db.Players.Add(Marquinhos);
                db.Players.Add(Pacho);
                db.Players.Add(Hernandez);
                db.Players.Add(Hakimi);
                db.Players.Add(Mendes);
                db.Players.Add(Lee);
                db.Players.Add(Warren);
                db.Players.Add(Mbaye);
                db.Players.Add(Vitinha);
                db.Players.Add(Ruiz);
                db.Players.Add(Neves);
                db.Players.Add(Kvara);
                db.Players.Add(Barcola);
                db.Players.Add(Dembele);
                db.Players.Add(Ramos);
                db.Players.Add(Doue);
                db.Players.Add(mayulu);
                db.Players.Add(Tape);
                db.Players.Add(Kamara);

                db.Matches.Add(match1);
                db.Matches.Add(match2);
                db.Matches.Add(match3);

                db.ICMatches.Add(icmatch1);
                db.ICMatches.Add(icmatch2);

                db.Coachs.Add(_Coach);
                db.SaveChanges();

                Console.WriteLine("SAVED");
            }
        }
    }
}
