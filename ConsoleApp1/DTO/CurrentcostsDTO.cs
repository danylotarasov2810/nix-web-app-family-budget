using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.DTO
{
    public class CurrentcostsDTO
    {
     
        public int Idcc { get; set; }
       
        public string Name { get; set; }
      
        public string Surname { get; set; }
      
        public string Date { get; set; }
        
        public int Articleitemcosts { get; set; }
        
        public float Summa { get; set; }
    }
}
