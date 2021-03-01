using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
namespace Cpa1.Models
{

    public class structure
    {
        private object p;

        public structure()
        {
        }

        public structure(object p)
        {
            this.p = p;
        }

        
        [Key]
        [Required]
        [MaxLength(5)]
       
        public int code { get; set; }

        [MaxLength(15)]
        public string abr { get; set; }

        [Required]
        [MaxLength(200)]
        public string desig { get; set; }

        [Required]
        [MaxLength(300)]
        public string adr { get; set; }

        [Required]
        [MaxLength(10)]
        [MinLength(9)]
        public string telephone { get; set; }

        [Required]
        [MaxLength(10)]
        [MinLength(9)]
        public string fax { get; set; }

        [Required]
        public int IDpersonne { get; set; }

        [Required]
        public int IDattaché { get; set; }

        [Required]
        public int Nligne { get; set; }


    }
}
