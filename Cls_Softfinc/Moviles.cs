using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Cls_Softfinc
{
  public  class Moviles
    {
        public Moviles()
        {
        }

        public int Id { get; set; }
        [StringLength(20)]
        public string Imei{ get; set; }
        [StringLength(50)]
        public string Uidapp { get; set; }       
        public int Status { get; set; }
        [StringLength(50)]
        public string Idempresa { get; set; }
        [StringLength(200)]
        public string Nota{ get; set; }
        [StringLength(50)]
        public string Ultip { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? F_registro { get; set; }
        [StringLength(50)]
        public string Clave { get; set; }
        [StringLength(50)]
        public string Idusuario { get; set; }
        [StringLength(10)]
        public string Version { get; set; }
        public Boolean Cambios { get; set; }
        public int Tprinter { get; set; }

    }


}
