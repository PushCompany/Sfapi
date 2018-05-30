using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using ApiSoftfinc.Models;
using Cls_Softfinc;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json.Linq;

namespace ApiSoftfinc.Controllers
{

    [Produces("application/json")]
    [Route("api/[controller]/[action]")]
    //[Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]

    public class CuentasController : Controller
    {

       private string keyinterno = Funciones.Keyinterno;

        public DbContextOptions<ApplicationDbContext> _Context { get; }

        public CuentasController(DbContextOptions<ApplicationDbContext> context)
        {
            _Context = context;
        }


        //Verifico si el movil esta registrado usuario entrante esta en Db registrado
        [HttpPost]
        public IActionResult Verificarmovil([FromBody] Moviles Model)
        {                      

            string Idempresa = "1";
            string nempresa = "1";
            string sloempresa = "1";
            string idusuario = "1";
            string nusuario = "1";
            string status = "0";
            string clave = "1";
            string fUltUpdate = String.Format("{0:dd/MM/yyyy HH:mm:ss}", DateTime.Now); ;
            Boolean cambios = true;
            string Tprinter = "0";
            Boolean Actualizar = false;
            
            //SI ES NULO 
            if (Model.Imei == null || Model.Imei.Length <= 4 )
            {
                status = "0";
            }
            else
            {
                  //si sl modelo no es nulo 
                var result = new Moviles();
                var Modempresa = new Configuracion();
                //verifico si el movil esta ingresado 
                using (var db = new ApplicationDbContext(_Context))
                {

                    result = db.TbMoviles.Where(x => x.Imei == Model.Imei)
                         .FirstOrDefault();
                }
                

                //si tengo el movil en lista 
                if (result != null)
                {
                    //si trae un registro  
                    //verifico si el Uidapp de la peticion es el mismo de registro 
                    if (string.Compare(Model.Uidapp, result.Uidapp) == 0)
                    {
                       //################# NOTA DE AQUI ENVIO DATA VERDADERA EL MOVIL 
                        //si el movil es el mismo 
                        //Recojo la empresa por el id del movil 
                        using (var db = new ApplicationDbContext(_Context))
                        {
                            Modempresa = db.TbConfiEmp.Where(x => x.Idempresa == result.Idempresa)
                                 .FirstOrDefault();
                        }

                        status = result.Status.ToString();
                        Idempresa = Modempresa.Idempresa;
                        nempresa = Modempresa.Nlargo;
                        sloempresa = Modempresa.Slogan;
                        idusuario = result.Idusuario;
                        nusuario = "Usuario#";
                        status = result.Status.ToString();
                        clave = result.Clave;
                        cambios = result.Cambios;
                        fUltUpdate = String.Format("{0:dd/MM/yyyy HH:mm:ss}", DateTime.Now);
                        Tprinter = result.Tprinter.ToString();



                        //######Actualizo Datos del movil 
                        //actualizo los datos de la actualizacion de la autorizacion 
                        using (var db = new ApplicationDbContext(_Context))
                        {
                            var update = result;

                            //#campos a actualizar
                            update.Version = Model.Version;
                            update.Ultip = Model.Ultip;
                            db.TbMoviles.Attach(update);                           
                            db.Entry(update).State = EntityState.Modified;
                            db.SaveChanges();
                           
                        }


                        //aqui Verifico si la version del movil esta obsoleta para enviarle actualizar=TRUE
                        using (var db = new ApplicationDbContext(_Context)) {

                            var Tbactualizarmb = db.TbActualizarAppEmpr.
                                Where(x => x.Idempresa == result.Idempresa).FirstOrDefault();

                            double version_actual = Double.Parse(result.Version);
                            double version_nueva = Double.Parse(Tbactualizarmb.Version);

                            //verifico si la version nueva es mayor que la vieja del movil para actualizar
                            if (version_nueva > version_actual) {
                                Actualizar = true;
                            }
                            else
                            {
                                Actualizar = false;
                            }
 

                        }



                        //if (result.Status == 0)
                        //{ //verifico si el status esta en 0 para bloquear
                        //    status = "0";
                        //}
                        //else
                        //{

                        //}


                    }
                    else
                    {
                        //si cambio el Uidapp //Verifico si lo tengo en Dbcambio_movil ya
                        var result2 = new CambioMovil();
                        using (var db = new ApplicationDbContext(_Context))
                        {
                            result2 = db.TbCambiomovil.Where(x => x.Imei == Model.Imei).
                            Where(x => x.Ejecutado == 0).FirstOrDefault();

                        }

                        if (result2 != null)
                        {

                            //actualizo los datos de la actualizacion de la autorizacion 
                            using (var db = new ApplicationDbContext(_Context))
                            {
                                var std = result2;
                                std.Uidapp = Model.Uidapp;
                                std.Fecha = DateTime.Now;
                                std.Ubicacion = Model.Ultip;
                                db.TbCambiomovil.Attach(std);
                                db.Entry(std).State = EntityState.Modified;
                                db.SaveChanges();
                            }

                        }
                        else
                        {
                         //si esta nulo ingreso un nuevo cambio de movil                             
                            using (var db = new ApplicationDbContext(_Context))
                            {
                                var result3 = new CambioMovil()
                                {
                                    Imei = Model.Imei,
                                    Ejecutado = 0,
                                    Fechaejecutado = DateTime.Now,
                                    Fecha = DateTime.Now,
                                    Nota = "",
                                    Notaejecucion = "",
                                    Ubicacion = "",
                                    Uidapp = Model.Uidapp,
                                    Idregistro = Guid.NewGuid().ToString()
                                };

                                db.Add(result3);
                                db.SaveChanges();
                            }
                        }
                        status = "0";
                    }


                    
                } else{

                    //######NOTA AQUI INGRESO EL MOVIL NUEVO REGISTRO  

                    //Si el movil entro nuevo lo registro como nuevo 
                    using (var db = new ApplicationDbContext(_Context))
                    {
                        var reslt = new Moviles()
                        {
                            Idusuario = "2311",
                            Clave = Funciones.Encrypt3("2311", keyinterno),
                            F_registro = DateTime.Now,
                            Idempresa = "",
                            Imei = Model.Imei,
                            Nota = "nota",
                            Status = 0,
                            Uidapp = Model.Uidapp,
                            Ultip = Model.Ultip,
                            Version = Model.Version,
                            Cambios = true,
                            Tprinter =0
                            
                            
                        };

                        db.Add(reslt);
                        db.SaveChanges();
                    }

                    status = "0";
                }
            }


            //var pais = new List<Pais>
            //{
            //    new Pais{ Id=1, Nombre="sd1" }   
            //};


            return Ok(new
            {
                data = new[]
            {
    new {


        _Idempresa =Idempresa,
         _nempresa =nempresa,
          _sloempresa =sloempresa,
           _idusuario =idusuario,
            _Status = status,
             _clave = clave,
              _fUltUpdate =fUltUpdate,
              _nusuario=nusuario,
              _cambios=cambios,
              _tprinter=Tprinter,
              _actualizarapp=Actualizar

         }

          }
            });

        }
                
        //Verifico si hay una version nueva en la empresa
        [HttpPost]
        public IActionResult RevisarActualizar([FromBody] JObject data)
        {
            string Idempresa = "";

            foreach (KeyValuePair<string, JToken> property in data)
            {
                Idempresa = property.Value.ToString();
                Console.WriteLine(property.Key + " - " + property.Value);
            }


            EmpActualizarapp resutl = new EmpActualizarapp();

            //si no esta vacia la empresa 
            if (Idempresa != "") {

                var Iddesencriptada = Funciones.Decrypt3(Idempresa, keyinterno);

                using (var db = new ApplicationDbContext(_Context)) {
                    resutl = db.TbActualizarAppEmpr.Where(x => x.Idempresa == Iddesencriptada).FirstOrDefault();
                    resutl.Appidupdate = Guid.NewGuid().ToString();//envio secret para descargar app 

                }

                return Json(resutl);


            }
            else
            {

                return Json(resutl);


            }



            //  var Item = data.c



          


        }

        //Verifico si entra acepta guardar host
        [HttpPost]
        public IActionResult Chekhost()
        {




                return Ok(new
                {
                    data = new[] {
    new {result= "1"}


                }
                });


        }




    }


}


