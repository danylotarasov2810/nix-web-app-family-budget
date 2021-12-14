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
        [Required]
        public int Idcc { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Surname { get; set; }
        [Required]
        public string Date { get; set; }
        [Required]
        public int Articleitemcosts { get; set; }
        [Required]
        public float Summa { get; set; }
    }
}
