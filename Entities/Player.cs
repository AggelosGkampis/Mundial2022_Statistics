using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Entities.Enums;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities
{
    public class Player
    {
        public int PlayerId { get; set; }

        public string Name { get; set; }

        public DateTime BirthDate { get; set; }

        public Position Position { get; set; }

        public string ImageUrl { get; set; }

        [NotMapped]
        public int Age
        {
            get { return DateTime.Now.Year - this.BirthDate.Year; }

        }
        
        // Navigation Properties

        public int TeamId { get; set; }

        public Team Team { get; set; }
    }
}