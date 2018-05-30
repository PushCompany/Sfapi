using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Cls_Softfinc
{
   public class Usuariosapi
    {
       
        public int Id { get; set; }
        [StringLength(100)]
        public string Idusuario { get; set; }
        [StringLength(100)]
        public  string Usuario { get; set; }
        [StringLength(100)]
        public string Clave { get; set; }
    }
}
