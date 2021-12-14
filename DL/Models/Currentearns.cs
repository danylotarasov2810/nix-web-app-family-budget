using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace DL.Models
{
    public class Currentearns
    {
        [Key]
        public int Idce { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Surname { get; set; }
        [Required]
        public string Date { get; set; }
        [Required]
        public int Articleitemearns { get; set; }
        [Required]
        [Range(1,1000000)]
        public float Summa { get; set; }
    }
}
