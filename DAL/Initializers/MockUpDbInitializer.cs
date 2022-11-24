using System.Data.Entity;
using Entities;
using System.Data.Entity.Migrations;
using Entities.Enums;
using System;
using System.Collections.Generic;

namespace DAL.Initializers
{
    internal class MockUpDbInitializer : DropCreateDatabaseAlways<ApplicationDbContext>
    {
        protected override void Seed(ApplicationDbContext context)
        {
            // Seedings

            #region Team Seeding

            Team t1 = new Team() { Name = "England", Rating = 9.5, SquadSize = 26, PhotoUrl = "https://tmssl.akamaized.net/images/flagge/tiny/189.png?lm=1520611569" };
            Team t2 = new Team() { Name = "Brazil", Rating = 9.5, SquadSize = 26, PhotoUrl = "https://tmssl.akamaized.net/images/flagge/tiny/26.png?lm=1520611569" };
            Team t3 = new Team() { Name = "France", Rating = 9.5, SquadSize = 25, PhotoUrl = "https://tmssl.akamaized.net/images/flagge/tiny/50.png?lm=1520611569" };
            Team t4 = new Team() { Name = "Portugal", Rating = 9, SquadSize = 26, PhotoUrl = "https://tmssl.akamaized.net/images/flagge/tiny/136.png?lm=1520611569" };
            Team t5 = new Team() { Name = "Germany", Rating = 9, SquadSize = 26, PhotoUrl = "https://tmssl.akamaized.net/images/flagge/tiny/40.png?lm=1520612525" };
            Team t6 = new Team() { Name = "Spain", Rating = 9, SquadSize = 26, PhotoUrl = "https://tmssl.akamaized.net/images/flagge/tiny/157.png?lm=1520611569" };
            Team t7 = new Team() { Name = "Argentina", Rating = 9, SquadSize = 26, PhotoUrl = "https://tmssl.akamaized.net/images/flagge/tiny/9.png?lm=1520611569" };                     
            Team t8 = new Team() { Name = "Netherlands", Rating = 8, SquadSize = 26, PhotoUrl = "https://tmssl.akamaized.net/images/flagge/tiny/122.png?lm=1520611569" };
            Team t9 = new Team() { Name = "Belgium", Rating = 8, SquadSize = 26, PhotoUrl = "https://tmssl.akamaized.net/images/flagge/tiny/19.png?lm=1520611569" };
            Team t10 = new Team() { Name = "Uruguay", Rating = 7.5, SquadSize = 26, PhotoUrl = "https://tmssl.akamaized.net/images/flagge/tiny/179.png?lm=1520611569" };
            Team t11 = new Team() { Name = "Croatia", Rating = 7.5, SquadSize = 26, PhotoUrl = "https://tmssl.akamaized.net/images/flagge/tiny/37.png?lm=1520611569" };
            Team t12 = new Team() { Name = "Serbia", Rating = 7.5, SquadSize = 26, PhotoUrl = "https://tmssl.akamaized.net/images/flagge/tiny/215.png?lm=1520611569" };
            
            context.Teams.AddOrUpdate(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12);
            context.SaveChanges();

            #endregion

            #region Players Seeding

            // England
            Player p1 = new Player() { Name = "Phil Foden", Position = Position.CM , BirthDate =new DateTime(2000,05,28) , IsCaptain = false, ImageUrl = "https://img.a.transfermarkt.technology/portrait/header/406635-1668524492.jpg?lm=1" }; 
            Player p2 = new Player() { Name = "Jude Bellingham", Position = Position.CM , BirthDate =new DateTime(2003,06,29) , IsCaptain = false, ImageUrl = "https://img.a.transfermarkt.technology/portrait/header/581678-1661412719.jpg?lm=1" }; 
            Player p3 = new Player() { Name = "Harry Kane", Position = Position.CF , BirthDate =new DateTime(1993,07,28) , IsCaptain = true, ImageUrl = "https://img.a.transfermarkt.technology/portrait/header/132098-1623778520.jpg?lm=1" }; 
            Player p4 = new Player() { Name = "Bukayo Saka", Position = Position.RM , BirthDate =new DateTime(2001,09,05) , IsCaptain = false, ImageUrl = "https://img.a.transfermarkt.technology/portrait/header/433177-1665513395.jpg?lm=1" }; 
            Player p5 = new Player() { Name = "Declan Rice", Position = Position.DM , BirthDate =new DateTime(1999,01,14) , IsCaptain = false, ImageUrl = "https://img.a.transfermarkt.technology/portrait/header/357662-1624883831.jpg?lm=1" }; 
            Player p6 = new Player() { Name = "Mason Mount", Position = Position.AM , BirthDate =new DateTime(1993,01,10) , IsCaptain = false, ImageUrl = "https://img.a.transfermarkt.technology/portrait/header/346483-1642175298.jpg?lm=1" };
            Player p7 = new Player() { Name = "Raheem Sterling", Position = Position.LW , BirthDate =new DateTime(1994,12,08) , IsCaptain = false, ImageUrl = "https://img.a.transfermarkt.technology/portrait/header/134425-1577051521.jpg?lm=1" };
            Player p8 = new Player() { Name = "Jack Grealish", Position = Position.LW , BirthDate =new DateTime(1995,09,10) , IsCaptain = false, ImageUrl = "https://img.a.transfermarkt.technology/portrait/header/203460-1581417066.jpg?lm=1" }; 
            Player p9 = new Player() { Name = "Alexander-Arnold", Position = Position.RB , BirthDate =new DateTime(1998,10,07) , IsCaptain = false, ImageUrl = "https://img.a.transfermarkt.technology/portrait/header/314353-1662621037.jpg?lm=1" }; 
            Player p10 = new Player() { Name = "James Maddison", Position = Position.AM , BirthDate =new DateTime(1996,11,23) , IsCaptain = false, ImageUrl = "https://img.a.transfermarkt.technology/portrait/header/294057-1638811548.jpg?lm=1" }; 
            Player p11 = new Player() { Name = "Ben White", Position = Position.CB , BirthDate =new DateTime(1997,10,08) , IsCaptain = false, ImageUrl = "https://img.a.transfermarkt.technology/portrait/header/335721-1668091170.jpg?lm=1" };

            // Brazil
            Player p27 = new Player() { Name = "Vinicius Junior", Position = Position.LW, BirthDate = new DateTime(2000, 07, 12),IsCaptain=false, ImageUrl = "https://img.a.transfermarkt.technology/portrait/header/371998-1664869583.jpg?lm=1" };
            Player p28 = new Player() { Name = "Rodrygo", Position = Position.RW, BirthDate = new DateTime(2001, 01, 09), IsCaptain = false, ImageUrl = "https://img.a.transfermarkt.technology/portrait/header/412363-1653297541.jpg?lm=1" };
            Player p29 = new Player() { Name = "Neymar", Position = Position.LW, BirthDate = new DateTime(1992, 02, 05), IsCaptain = false, ImageUrl = "https://img.a.transfermarkt.technology/portrait/header/68290-1632687616.jpg?lm=1" };
            Player p30 = new Player() { Name = "Gabriel Jesus", Position = Position.CF, BirthDate = new DateTime(1997, 04, 03), IsCaptain = false, ImageUrl = "https://img.a.transfermarkt.technology/portrait/header/363205-1533284263.jpg?lm=1" };
            Player p31 = new Player() { Name = "Antony", Position = Position.RW, BirthDate = new DateTime(2000, 02, 24), IsCaptain = false, ImageUrl = "https://img.a.transfermarkt.technology/portrait/header/602105-1661861635.jpg?lm=1" };
            Player p32 = new Player() { Name = "Marquinhos", Position = Position.CB, BirthDate = new DateTime(1994, 05, 14), IsCaptain = true, ImageUrl = "https://img.a.transfermarkt.technology/portrait/header/181767-1639581124.jpg?lm=1" };
            Player p33 = new Player() { Name = "Éder Militão", Position = Position.CB, BirthDate = new DateTime(1998, 01, 18), IsCaptain = false, ImageUrl = "https://img.a.transfermarkt.technology/portrait/header/401530-1568189259.jpg?lm=1" };
            Player p34 = new Player() { Name = "Bruno Guimarães", Position = Position.DM, BirthDate = new DateTime(1997, 11, 16), IsCaptain = false, ImageUrl = "https://img.a.transfermarkt.technology/portrait/header/520624-1668522672.jpg?lm=1" };
            Player p35 = new Player() { Name = "Gabriel Martinelli", Position = Position.LW, BirthDate = new DateTime(2001, 01, 18), IsCaptain = false, ImageUrl = "https://img.a.transfermarkt.technology/portrait/header/655488-1665499061.jpg?lm=1" };
            Player p36 = new Player() { Name = "Fabinho", Position = Position.DM, BirthDate = new DateTime(1993, 10, 23), IsCaptain = false, ImageUrl = "https://img.a.transfermarkt.technology/portrait/header/225693-1580133493.jpg?lm=1" };
            Player p37 = new Player() { Name = "Casemiro", Position = Position.DM, BirthDate = new DateTime(1992, 02, 23), IsCaptain = false, ImageUrl = "https://img.a.transfermarkt.technology/portrait/header/16306-1661426172.jpg?lm=1" };
            Player p38 = new Player() { Name = "Alisson", Position = Position.GK, BirthDate = new DateTime(1992, 10, 02), IsCaptain = false, ImageUrl = "https://img.a.transfermarkt.technology/portrait/header/105470-1668522221.jpg?lm=1" };

            context.Players.AddOrUpdate(p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p27, p28, p29, p30, p31, p32, p33, p34, p35, p36, p37, p38);
            context.SaveChanges();

            #endregion

            #region Coaches Seeding

            Coach c1 = new Coach() { Name = "Gareth Southgate", BirthDate = new DateTime(1970, 09, 03), ImageUrl = "https://img.a.transfermarkt.technology/portrait/header/3358-1528450702.jpg?lm=1" };
            Coach c2 = new Coach() { Name = "Tite", BirthDate = new DateTime(1961, 05, 25), ImageUrl = "https://img.a.transfermarkt.technology/portrait/header/6623-1448023024.jpg?lm=1" };
            Coach c3 = new Coach() { Name = "Didier Deschamps", BirthDate = new DateTime(1968, 10, 15), ImageUrl = "https://img.a.transfermarkt.technology/portrait/header/1229-1564582636.jpg?lm=1" };

            context.Coaches.AddOrUpdate(c1, c2, c3);
            context.SaveChanges();
            #endregion

            #region Relations Between Entities

            // Teams With Players

            t1.Players = new List<Player>() { p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11 };
            p1.Team = t1;
            p2.Team = t1;
            p3.Team = t1;
            p4.Team = t1;
            p5.Team = t1;
            p6.Team = t1;
            p7.Team = t1;
            p8.Team = t1;
            p9.Team = t1;
            p10.Team = t1;
            p11.Team = t1;
            t2.Players = new List<Player>() { p27, p28, p29, p30, p31, p32, p33, p34, p35, p36, p37, p38 };
            p27.Team = t2;
            p28.Team = t2;
            p29.Team = t2;
            p30.Team = t2;
            p31.Team = t2;
            p32.Team = t2;
            p33.Team = t2;
            p34.Team = t2;
            p35.Team = t2;
            p36.Team = t2;
            p37.Team = t2;
            p38.Team = t2;

            // Teams With Coaches

            t1.Coach = c1;
            c1.Team = t1;
            t2.Coach = c2;
            c2.Team = t2;
            t3.Coach = c3;
            c3.Team = t3;

            #endregion


            base.Seed(context);                                            
        }                                                                  
    }                                                                      
}                                                                          
                                                                           
                                                                           
                                                                           
                                                                           