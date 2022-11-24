using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Coach
    {        
        public int Id { get; set; }
        public string Name { get; set; }

        public DateTime BirthDate { get; set; }

        public string ImageUrl { get; set; }


        [NotMapped]
        public int Age
        {
            get { return DateTime.Now.Year - this.BirthDate.Year; }

        }



        // Navigation Properties
        public Team Team { get; set; }


    }
}
