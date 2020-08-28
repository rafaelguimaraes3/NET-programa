using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace rafael_guimaraes.Models
{
    public class pessoa
    {
        [Key]
        public string Nome { get; set; }
        public DateTime Data { get; set; }
        public double Salario { get; set; }

            
    }
}
