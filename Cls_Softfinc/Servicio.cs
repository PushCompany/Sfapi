using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Cls_Softfinc
{
   public class SrvActualizacion
    {

        public int Id { get; set; }
        //para manejar el servicio de de dotnet core
        [Column(TypeName = "datetime")]
        public DateTime Inicio { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime Ultactualizacion { get; set; }
        public int Procesos { get; set; }
        public int Detener { get; set; }




    }
}
