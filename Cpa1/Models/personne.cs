using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Cpa1.Models
{
    public class Personne
    {
        [Key]
        [Required]
        [MaxLength(5)]
        public int code { get; set; }

        [Required]
        [MaxLength(50)]
        [MinLength(2)]
        public string Nom { get; set; }

        [Required]
        [MaxLength(50)]
        [MinLength(2)]
        public string Prenom { get; set; }

        [Required]
        [MaxLength(100)]
        public string qualite { get; set; }
    }
}

