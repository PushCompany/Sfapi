using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Cls_Softfinc
{
    public class CambioMovil
    {

        public int Id { get; set; }
        [StringLength(50)]
        public string Idregistro { get; set; }
        [StringLength(20)]
        public string Imei { get; set; }
        [StringLength(50)]
        public string Uidapp { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? Fecha { get; set; }
        public int Ejecutado { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? Fechaejecutado { get; set; }
        [StringLength(50)]
        public string Notaejecucion { get; set; }
        [StringLength(50)]
        public string Nota { get; set; }
        [StringLength(300)]
        public string Ubicacion { get; set; }


    }
}
