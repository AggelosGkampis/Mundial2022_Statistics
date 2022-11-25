using DAL;
using Entities;
using Entities.Enums;
using RepositoryServices;
using RepositoryServices.Core;
using RepositoryServices.Persistance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Experiments
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ApplicationDbContext db = new ApplicationDbContext();

            UnitOfWork unit = new UnitOfWork(db);

            var teams = unit.Teams.GetTeamsOrderByDescending();

            foreach (var team in teams)
            {
                Console.WriteLine(team.Name);
            }








           //ApplicationDbContext db = new ApplicationDbContext();

           // TeamRepository teamRepository = new TeamRepository(db);
           // PlayerRepository playerRepository = new PlayerRepository(db);
           // CoachRepository coachRepository = new CoachRepository(db);

           // foreach (var team in teamRepository.GetTeamsOrderByAscending())
           // {
           //     Console.WriteLine(team.Name);
           // }

           // foreach (var player in playerRepository.GetAllPlayersByPosition())
           // {
           //     Console.WriteLine(player.Name);
           //     Console.WriteLine(player.Position);
           // }

           // Console.WriteLine("----------------------");
           // Console.WriteLine("----------------------");
           // Console.WriteLine("----------------------");

           // foreach (var coach in coachRepository.GetAllCoachesByNameAsc())
           // {
           //     Console.WriteLine(coach.Name);

           // }
        }
    }
}
