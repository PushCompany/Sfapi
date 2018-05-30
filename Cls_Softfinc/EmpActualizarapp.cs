using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Cls_Softfinc
{
   public  class EmpActualizarapp
    {
        //aqui guardo las empresa que hay que actualizar revisando la version de app con la de empresa en el movil 
        public int Id { get; set; }
        [StringLength(50)]
        public string Idempresa { get; set; }
        [StringLength(50)]
        public string Version { get; set; }
        [StringLength(200)]
        public string Nota{ get; set; }
        [StringLength(100)]
        public string Urlapp { get; set; }
        public Boolean Actualizar { get; set; }
        [StringLength(100)]
        public string Appidupdate { get; set; }

    }
}
