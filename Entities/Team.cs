using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Entities
{
    public class Team
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="Team name is mandatory"),MaxLength(60),MinLength(2)]
        public string Name { get; set; }  
        
        public double Rating { get; set; } 

        public string PhotoUrl { get; set; }
        [Range(0,28)]
        public int SquadSize { get; set; }  

        // Navigation Properties

        public virtual List<Player> Players { get; set; }  // ICollection

        public Coach Coach { get; set; }
    }
}
