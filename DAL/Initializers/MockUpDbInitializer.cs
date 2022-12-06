using System.Data.Entity;
using Entities;
using System.Data.Entity.Migrations;
using Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DAL.Initializers
{
    internal class MockUpDbInitializer : DropCreateDatabaseAlways<ApplicationDbContext> //CreateDatabaseIfNotExists<ApplicationDbContext> 
    {
        protected override void Seed(ApplicationDbContext context)
        {
            // Seedings

            #region Players Seeding

            // England

            Player p1 = new Player() { Name = "Phil Foden", Position = Position.CM, BirthDate = new DateTime(2000, 05, 28), IsCaptain = false, ImageUrl = "https://img.a.transfermarkt.technology/portrait/header/406635-1668524492.jpg?lm=1",};
            Player p2 = new Player() { Name = "Jude Bellingham", Position = Position.CM, BirthDate = new DateTime(2003, 06, 29), IsCaptain = false, ImageUrl = "https://img.a.transfermarkt.technology/portrait/header/581678-1661412719.jpg?lm=1" };
            Player p3 = new Player() { Name = "Harry Kane", Position = Position.CF, BirthDate = new DateTime(1993, 07, 28), IsCaptain = true, ImageUrl = "https://img.a.transfermarkt.technology/portrait/header/132098-1623778520.jpg?lm=1" };
            Player p4 = new Player() { Name = "Bukayo Saka", Position = Position.RM, BirthDate = new DateTime(2001, 09, 05), IsCaptain = false, ImageUrl = "https://img.a.transfermarkt.technology/portrait/header/433177-1665513395.jpg?lm=1" };
            Player p5 = new Player() { Name = "Declan Rice", Position = Position.DM, BirthDate = new DateTime(1999, 01, 14), IsCaptain = false, ImageUrl = "https://img.a.transfermarkt.technology/portrait/header/357662-1624883831.jpg?lm=1" };
            Player p6 = new Player() { Name = "Mason Mount", Position = Position.AM, BirthDate = new DateTime(1993, 01, 10), IsCaptain = false, ImageUrl = "https://img.a.transfermarkt.technology/portrait/header/346483-1642175298.jpg?lm=1" };
            Player p7 = new Player() { Name = "Raheem Sterling", Position = Position.LW, BirthDate = new DateTime(1994, 12, 08), IsCaptain = false, ImageUrl = "https://img.a.transfermarkt.technology/portrait/header/134425-1577051521.jpg?lm=1" };
            Player p8 = new Player() { Name = "Jack Grealish", Position = Position.LW, BirthDate = new DateTime(1995, 09, 10), IsCaptain = false, ImageUrl = "https://img.a.transfermarkt.technology/portrait/header/203460-1581417066.jpg?lm=1" };
            Player p9 = new Player() { Name = "Alexander-Arnold", Position = Position.RB, BirthDate = new DateTime(1998, 10, 07), IsCaptain = false, ImageUrl = "https://img.a.transfermarkt.technology/portrait/header/314353-1662621037.jpg?lm=1" };
            Player p10 = new Player() { Name = "James Maddison", Position = Position.AM, BirthDate = new DateTime(1996, 11, 23), IsCaptain = false, ImageUrl = "https://img.a.transfermarkt.technology/portrait/header/294057-1638811548.jpg?lm=1" };
            Player p11 = new Player() { Name = "Ben White", Position = Position.CB, BirthDate = new DateTime(1997, 10, 08), IsCaptain = false, ImageUrl = "https://img.a.transfermarkt.technology/portrait/header/335721-1668091170.jpg?lm=1" };

            // Brazil
            Player p12 = new Player() { Name = "Vinicius Junior", Position = Position.LW, BirthDate = new DateTime(2000, 07, 12), IsCaptain = false, ImageUrl = "https://img.a.transfermarkt.technology/portrait/header/371998-1664869583.jpg?lm=1" };
            Player p13 = new Player() { Name = "Rodrygo", Position = Position.RW, BirthDate = new DateTime(2001, 01, 09), IsCaptain = false, ImageUrl = "https://img.a.transfermarkt.technology/portrait/header/412363-1653297541.jpg?lm=1" };
            Player p14 = new Player() { Name = "Neymar", Position = Position.LW, BirthDate = new DateTime(1992, 02, 05), IsCaptain = false, ImageUrl = "https://img.a.transfermarkt.technology/portrait/header/68290-1632687616.jpg?lm=1" };
            Player p15 = new Player() { Name = "Gabriel Jesus", Position = Position.CF, BirthDate = new DateTime(1997, 04, 03), IsCaptain = false, ImageUrl = "https://img.a.transfermarkt.technology/portrait/header/363205-1533284263.jpg?lm=1" };
            Player p16 = new Player() { Name = "Antony", Position = Position.RW, BirthDate = new DateTime(2000, 02, 24), IsCaptain = false, ImageUrl = "https://img.a.transfermarkt.technology/portrait/header/602105-1661861635.jpg?lm=1" };
            Player p17 = new Player() { Name = "Marquinhos", Position = Position.CB, BirthDate = new DateTime(1994, 05, 14), IsCaptain = true, ImageUrl = "https://img.a.transfermarkt.technology/portrait/header/181767-1639581124.jpg?lm=1" };
            Player p18 = new Player() { Name = "Eder Militao", Position = Position.CB, BirthDate = new DateTime(1998, 01, 18), IsCaptain = false, ImageUrl = "https://img.a.transfermarkt.technology/portrait/header/401530-1568189259.jpg?lm=1" };
            Player p19 = new Player() { Name = "Bruno Guimaraes", Position = Position.DM, BirthDate = new DateTime(1997, 11, 16), IsCaptain = false, ImageUrl = "https://img.a.transfermarkt.technology/portrait/header/520624-1668522672.jpg?lm=1" };
            Player p20 = new Player() { Name = "Gabriel Martinelli", Position = Position.LW, BirthDate = new DateTime(2001, 01, 18), IsCaptain = false, ImageUrl = "https://img.a.transfermarkt.technology/portrait/header/655488-1665499061.jpg?lm=1" };
            Player p21 = new Player() { Name = "Fabinho", Position = Position.DM, BirthDate = new DateTime(1993, 10, 23), IsCaptain = false, ImageUrl = "https://img.a.transfermarkt.technology/portrait/header/225693-1580133493.jpg?lm=1" };
            Player p22 = new Player() { Name = "Casemiro", Position = Position.DM, BirthDate = new DateTime(1992, 02, 23), IsCaptain = false, ImageUrl = "https://img.a.transfermarkt.technology/portrait/header/16306-1661426172.jpg?lm=1" };
            Player p23 = new Player() { Name = "Alisson", Position = Position.GK, BirthDate = new DateTime(1992, 10, 02), IsCaptain = false, ImageUrl = "https://img.a.transfermarkt.technology/portrait/header/105470-1668522221.jpg?lm=1" };


            #endregion


            #region Team Seeding

            Team t1 = new Team()
            {
                Name = "England",
                Rating = 9.5,
                SquadSize = 26,
                TimesWonWorldCup = 1,
                GoalsScored = 91,
                PhotoUrl = "https://tmssl.akamaized.net/images/flagge/tiny/189.png?lm=1520611569"
            };
            t1.Players = new List<Player>() { p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11 };            
            Team t2 = new Team()
            {
                Name = "Brazil",
                Rating = 9.5,
                SquadSize = 26,
                TimesWonWorldCup = 5,
                GoalsScored = 229,
                PhotoUrl = "https://tmssl.akamaized.net/images/flagge/tiny/26.png?lm=1520611569"
            };
            t2.Players = new List<Player>() { p12, p13, p14, p15, p16, p17, p18, p19, p20, p21, p22, p23 };
            Team t3 = new Team()
            {
                Name = "France",
                Rating = 9.5,
                SquadSize = 25,
                TimesWonWorldCup = 2,
                GoalsScored = 120,
                PhotoUrl = "https://tmssl.akamaized.net/images/flagge/tiny/50.png?lm=1520611569"
            };
            Team t4 = new Team()
            {
                Name = "Portugal",
                Rating = 9,
                SquadSize = 26,
                TimesWonWorldCup = 0,
                GoalsScored = 71,
                PhotoUrl = "https://tmssl.akamaized.net/images/flagge/tiny/136.png?lm=1520611569"
            };
            Team t5 = new Team()
            {
                Name = "Germany",
                Rating = 9,
                SquadSize = 26,
                TimesWonWorldCup = 4,
                GoalsScored = 226,
                PhotoUrl = "https://tmssl.akamaized.net/images/flagge/tiny/40.png?lm=1520612525"
            };
            Team t6 = new Team()
            {
                Name = "Spain",
                Rating = 9,
                SquadSize = 26,
                TimesWonWorldCup = 1,
                GoalsScored = 99,
                PhotoUrl = "https://tmssl.akamaized.net/images/flagge/tiny/157.png?lm=1520611569"
            };
            Team t7 = new Team()
            {
                Name = "Argentina",
                Rating = 9,
                SquadSize = 26,
                TimesWonWorldCup = 2,
                GoalsScored = 137,
                PhotoUrl = "https://tmssl.akamaized.net/images/flagge/tiny/9.png?lm=1520611569"
            };
            Team t8 = new Team()
            {
                Name = "Netherlands",
                Rating = 8,
                SquadSize = 26,
                TimesWonWorldCup = 0,
                GoalsScored = 86,
                PhotoUrl = "https://tmssl.akamaized.net/images/flagge/tiny/122.png?lm=1520611569"
            };
            Team t9 = new Team()
            {
                Name = "Belgium",
                Rating = 8,
                SquadSize = 26,
                TimesWonWorldCup = 0,
                GoalsScored = 41,
                PhotoUrl = "https://tmssl.akamaized.net/images/flagge/tiny/19.png?lm=1520611569"
            };
            Team t10 = new Team()
            {
                Name = "Uruguay",
                Rating = 7.5,
                SquadSize = 26,
                TimesWonWorldCup = 2,
                GoalsScored = 87,
                PhotoUrl = "https://tmssl.akamaized.net/images/flagge/tiny/179.png?lm=1520611569"
            };
            Team t11 = new Team()
            {
                Name = "Croatia",
                Rating = 7.5,
                SquadSize = 26,
                TimesWonWorldCup = 0,
                GoalsScored = 46,
                PhotoUrl = "https://tmssl.akamaized.net/images/flagge/tiny/37.png?lm=1520611569"
            };
            Team t12 = new Team()
            {
                Name = "Serbia",
                Rating = 7.5,
                SquadSize = 26,
                TimesWonWorldCup = 0,
                GoalsScored = 37,
                PhotoUrl = "https://tmssl.akamaized.net/images/flagge/tiny/215.png?lm=1520611569"
            };




            #endregion

           

            #region Coaches Seeding

            Coach c1 = new Coach() { Name = "Gareth Southgate", BirthDate = new DateTime(1970, 09, 03), ImageUrl = "https://img.a.transfermarkt.technology/portrait/header/3358-1528450702.jpg?lm=1" };    
            c1.Team = t1;
            Coach c2 = new Coach() { Name = "Tite", BirthDate = new DateTime(1961, 05, 25), ImageUrl = "https://img.a.transfermarkt.technology/portrait/header/6623-1448023024.jpg?lm=1" };   
            c2.Team = t2;
            Coach c3 = new Coach() { Name = "Didier Deschamps", BirthDate = new DateTime(1968, 10, 15), ImageUrl = "https://img.a.transfermarkt.technology/portrait/header/1229-1564582636.jpg?lm=1" };      
            c3.Team = t3;
            t1.Coach=c1; 
            t2.Coach=c2; 
            t3.Coach=c3;


            #endregion


            #region UserFavPlayer Seeding
            UserFavPlayers user1 = new UserFavPlayers() { PlayerId= 1 , UserId = "57741483-0730-4bf9-827c-7095bb52fb10", PlayerChose = new DateTime(2022,10,10)};
            UserFavPlayers user2 = new UserFavPlayers() { PlayerId= 5 , UserId = "57741483-0730-4bf9-827c-7095bb52fb10", PlayerChose = new DateTime(2022,10,11)};
            UserFavPlayers user3 = new UserFavPlayers() { PlayerId= 12 , UserId = "57741483-0730-4bf9-827c-7095bb52fb10", PlayerChose = new DateTime(2022,10,12)};
            UserFavPlayers user4 = new UserFavPlayers() { PlayerId= 25 , UserId = "d61a6d64-6329-4d1b-a4b1-6326d8ab6e73", PlayerChose = new DateTime(2022,5,10)};
            UserFavPlayers user5 = new UserFavPlayers() { PlayerId= 7 , UserId = "d61a6d64-6329-4d1b-a4b1-6326d8ab6e73", PlayerChose = new DateTime(2022,6,10)};

            #endregion

            #region Relations Between Entities

            // Teams With Players

            //t1.Players.Add(p1);
            //t1.Players.Add(p2);
            //t1.Players.Add(p3);
            //t1.Players.Add(p4);
            //t1.Players.Add(p5);
            //t1.Players.Add(p6);
            //t1.Players.Add(p7);
            //t1.Players.Add(p8);
            //t1.Players.Add(p9);
            //t1.Players.Add(p10);
            //t1.Players.Add(p11);
            //t2.Players.Add(p12);
            //t2.Players.Add(p13);
            //t2.Players.Add(p14);
            //t2.Players.Add(p15);
            //t2.Players.Add(p16);
            //t2.Players.Add(p17);
            //t2.Players.Add(p18);
            //t2.Players.Add(p19);
            //t2.Players.Add(p20);
            //t2.Players.Add(p21);
            //t2.Players.Add(p22);
            //t2.Players.Add(p23);
            context.UserFavPlayers.AddOrUpdate(user1, user2, user3, user4, user5);
            context.Teams.AddOrUpdate(t=>t.Id,t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12);
            context.Coaches.AddOrUpdate(c => c.Name, c1, c2, c3);
            context.Players.AddOrUpdate(t => t.Name, p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14, p15, p16, p17, p18, p19, p20, p21, p22, p23);
            context.SaveChanges();














            //t1.Players = new List<Player>() { p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11 };
            //p1.Team = t1;
            //p2.Team = t1;
            //p3.Team = t1;
            //p4.Team = t1;
            //p5.Team = t1;
            //p6.Team = t1;
            //p7.Team = t1;
            //p8.Team = t1;
            //p9.Team = t1;
            //p10.Team = t1;
            //p11.Team = t1;

            //t2.Players = new List<Player>() { p12, p13, p14, p15, p16, p17, p18, p19, p20, p21, p22, p23 };
            //p12.Team = t2;
            //p13.Team = t2;
            //p14.Team = t2;
            //p15.Team = t2;
            //p16.Team = t2;
            //p17.Team = t2;
            //p18.Team = t2;
            //p19.Team = t2;
            //p20.Team = t2;
            //p21.Team = t2;
            //p22.Team = t2;
            //p23.Team = t2;


            //context.SaveChanges();

            #endregion


            base.Seed(context);
        }
    }
}



