using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Cls_Softfinc
{
   public class Configuracion
    {
        public int Id { get; set; }
        [StringLength(100)]
        public string Idempresa { get; set; }
        [StringLength(100)]
        public string Ncorto { get; set; }
        [StringLength(100)]
        public string Nlargo { get; set; }
        [StringLength(100)]
        public string Direccion { get; set; }
        [StringLength(100)]       
        public string Telefono { get; set; }
        public string Slogan{ get; set; }
        public int Status{ get; set; }
    }
}
