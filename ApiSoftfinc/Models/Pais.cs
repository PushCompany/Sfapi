using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ApiSoftfinc.Models
{
    public class Pais
    {

       

        public int Id { get; set; }
        [StringLength(30)]
        [Required]
        public string Nombre { get; set; }
      
    }
}
