﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Pierwszy_projekt_na_serio.Models.Entity
{
    public class Client
    {
        [Key]
        public int ClientId { get; set; }
        public string Full_name { get; set; }
        public string Adress { get; set; }
        public string Country_code { get; set; }
    }
}
