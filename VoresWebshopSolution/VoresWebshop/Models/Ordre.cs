﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace VoresWebshop.Models
{
    public class Ordre
    {
        public int OrdreID { get; set; }

        [Required]
        public int BrugerID { get; set; }
        public DateTime? Oprettet { get; set; }
        public DateTime? Godkendt { get; set; }
        public DateTime? Afsendt { get; set; }
        public DateTime? Afsluttet { get; set; }
        public virtual ICollection<OrdreLinie> OrdreLinier { get; set; }
    }
}
