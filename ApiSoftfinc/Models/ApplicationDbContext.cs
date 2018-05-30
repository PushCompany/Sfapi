using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiSoftfinc.Models
{
    public class ApplicationDbContext:DbContext
    {

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

        }


      public DbSet<Cls_Softfinc.Moviles> TbMoviles { get; set; }// Guardar datos de los moviles
       public DbSet<Cls_Softfinc.CambioMovil> TbCambiomovil { get; set; } //Marcar Cambio de Movil 
      public DbSet<Cls_Softfinc.Configuracion> TbConfiEmp { get; set; }//configuracion de empresas
       public DbSet<Cls_Softfinc.EmpActualizarapp> TbActualizarAppEmpr { get; set; }//Apunte para actualizar app 
        public DbSet<Cls_Softfinc.SrvActualizacion> TbSrvActualizacion { get; set; }//Apunte para actualizar app 

    }
}
