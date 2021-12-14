using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace DL.Models
{
    public class Atriclecosts
    {
        [Required]
        public int Articleitemcosts { get; set; }
        [Required]
        public string Namearticlecosts { get; set; }
    }
}
