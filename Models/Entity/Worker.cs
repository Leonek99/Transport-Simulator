using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Pierwszy_projekt_na_serio.Models.Entity
{
    public class Worker
    {
        [Key]
        public int WorkerId { get; set; }
        public string Full_name { get; set; }
        public string adress { get; set; }
        public string country_code { get; set; }
    }
}
