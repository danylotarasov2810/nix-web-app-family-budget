using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace DL.Models
{
    public class Users
    {
        [Key]
        public int IdU { get; set; }
        [Required]
        [StringLength(10)]
        public string Name { get; set; }
        [Required]
        [StringLength(15)]
        public string Surname { get; set; }
        [Required]
        public string Relationdegree { get; set; }
        [Required]
        [Range(1,130)]
        public int Years { get; set; }
        [Required(ErrorMessage = "Укажите правильный email")]
        [EmailAddress]
        public string Email { get; set; }
        [Required(ErrorMessage = "Укажите номер телефона")]
        [RegularExpression("^(?!0+$)(\\+\\d{1,3}[- ]?)?(?!0+$)\\d{10,15}$", ErrorMessage = "Enter valid mobile number")]
        public string Phone{ get; set; }

    }
}
