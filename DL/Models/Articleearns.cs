using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace DL.Models
{
    public class Articleearns
    {
        [Required]
        public int Articleitemearns { get; set; }
        [Required]
        [MaxLength(50)]
        public string Namearticleearns { get; set; }
    }
}
