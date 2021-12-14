using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace DL.Models
{
    public class Currentcosts
    {
        [Key]
        public int Idcc { get; set; }
        [Required]
        [MaxLength(25)]
        public string Name { get; set; }
        [Required]
        [MaxLength(30)]
        public string Surname { get; set; }
        [Required]
        public string Date { get; set; }
        [Required]
        public int Articleitemcosts { get; set; }
        [Required]
        [Range(1, 1000000)]
        public float Summa { get; set; }
    }
}
