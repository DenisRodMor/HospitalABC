using Entidades;
using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Hospital_ABC.Controllers
{
    public class RegistroCitasController : Controller
    {

        private readonly Logger gobjLogger = LogManager.GetCurrentClassLogger();


        public ActionResult recRegistroCitas_PA()
        {
            List<PA_RegistroCitas_MostrarDetalle_Result> lObjRespuesta = new List<PA_RegistroCitas_MostrarDetalle_Result>();
            try
            {
                using (srvRegistroCitas.IsrvRegistroCitasClient srvhospital = new srvRegistroCitas.IsrvRegistroCitasClient())
                {
                    lObjRespuesta = srvhospital.recRegistroCitas_PA();
                }
            }
            catch (Exception ex)
            {

                gobjLogger.Error("Se produjo un error. Detalle " + ex.Message + " " + ex.InnerException.Message);
                throw ex;
            }
            return View(lObjRespuesta);
        }

        public ActionResult AgregaRegistroCitas_PA()
        {


            return View();
        }

        public ActionResult ModificaRegistroCitas_PA(int id)
        {
            PA_RegistroCitas_MostrarDetallexid_Result lObjRespuesta = new PA_RegistroCitas_MostrarDetallexid_Result();
            try
            {
                using (srvRegistroCitas.IsrvRegistroCitasClient srvHospital = new srvRegistroCitas.IsrvRegistroCitasClient())
                {
                    lObjRespuesta = srvHospital.recRegistroCitasXID_PA(id);
                }
            }
            catch (Exception ex)
            {
                gobjLogger.Error("Se produjo un error. Detalle " + ex.Message + " " + ex.InnerException.Message);
                throw ex;
            }
            return View(lObjRespuesta);

        }

        public ActionResult EliminarRegistroCitas_PA(int id)
        {
            PA_RegistroCitas_MostrarDetallexid_Result lObjRespuesta = new PA_RegistroCitas_MostrarDetallexid_Result();
            try
            {
                using (srvRegistroCitas.IsrvRegistroCitasClient srvHospital = new srvRegistroCitas.IsrvRegistroCitasClient())
                {
                    lObjRespuesta = srvHospital.recRegistroCitasXID_PA(id);
                }
            }
            catch (Exception ex)
            {
                gobjLogger.Error("Se produjo un error. Detalle " + ex.Message + " " + ex.InnerException.Message);
                throw ex;
            }
            return View(lObjRespuesta);

        }

        public ActionResult DetalleRegistroCitas_PA(int id)
        {
            PA_RegistroCitas_MostrarDetallexid_Result lObjRespuesta = new PA_RegistroCitas_MostrarDetallexid_Result();
            try
            {
                using (srvRegistroCitas.IsrvRegistroCitasClient srvHospital = new srvRegistroCitas.IsrvRegistroCitasClient())
                {
                    lObjRespuesta = srvHospital.recRegistroCitasXID_PA(id);
                }
            }
            catch (Exception ex)
            {
                gobjLogger.Error("Se produjo un error. Detalle " + ex.Message + " " + ex.InnerException.Message);
                throw ex;
            }
            return View(lObjRespuesta);

        }

        public ActionResult AccionesEntidades(string submitButton, RegistroCitas pregistrocitas)
        {
            try
            {
                switch (submitButton)
                {
                    case "Agregar":
                        return insertarRegistroCitas(pregistrocitas);
                    case "Actualizar":
                        return modificarRegistroCitas(pregistrocitas);
                    case "Eliminar":
                        return eliminarRegistroCitas(pregistrocitas);
                    default:
                        return RedirectToAction("recRegistroCitas_PA");
                }
            }
            catch (Exception ex)
            {
                gobjLogger.Error("Se produjo un error. Detalle " + ex.Message + " " + ex.InnerException.Message);
                throw ex;
            }
        }

        public ActionResult insertarRegistroCitas(RegistroCitas pregistrocitas)
        {
            List<PA_RegistroCitas_MostrarDetalle_Result> lObjRespuesta = new List<PA_RegistroCitas_MostrarDetalle_Result>();

            try
            {
                using (srvRegistroCitas.IsrvRegistroCitasClient srvHospital = new srvRegistroCitas.IsrvRegistroCitasClient())
                {

                    if (srvHospital.insRegistroCitas_PA(pregistrocitas))
                    {

                    }

                    lObjRespuesta = srvHospital.recRegistroCitas_PA();
                }
            }
            catch (Exception ex)
            {
                gobjLogger.Error("Se produjo un error. Detalle " + ex.Message + " " + ex.InnerException.Message);
                throw ex;
            }
            return View("recRegistroCitas_PA", lObjRespuesta);
        }

        public ActionResult modificarRegistroCitas(RegistroCitas pregistrocitas)
        {
            List<PA_RegistroCitas_MostrarDetalle_Result> lObjRespuesta = new List<PA_RegistroCitas_MostrarDetalle_Result>();

            try
            {
                using (srvRegistroCitas.IsrvRegistroCitasClient srvHospital = new srvRegistroCitas.IsrvRegistroCitasClient())
                {

                    if (srvHospital.modRegistroCitas_PA(pregistrocitas))
                    {

                    }

                    lObjRespuesta = srvHospital.recRegistroCitas_PA();
                }
            }
            catch (Exception ex)
            {
                gobjLogger.Error("Se produjo un error. Detalle " + ex.Message + " " + ex.InnerException.Message);
                throw ex;
            }
            return View("recRegistroCitas_PA", lObjRespuesta);
        }

        public ActionResult eliminarRegistroCitas(RegistroCitas pregistrocitas)
        {
            List<PA_RegistroCitas_MostrarDetalle_Result> lObjRespuesta = new List<PA_RegistroCitas_MostrarDetalle_Result>();

            try
            {
                using (srvRegistroCitas.IsrvRegistroCitasClient srvHospital = new srvRegistroCitas.IsrvRegistroCitasClient())
                {

                    if (srvHospital.delRegistroCitas_PA(pregistrocitas))
                    {

                    }

                    lObjRespuesta = srvHospital.recRegistroCitas_PA();
                }
            }
            catch (Exception ex)
            {
                gobjLogger.Error("Se produjo un error. Detalle " + ex.Message + " " + ex.InnerException.Message);
                throw ex;
            }
            return View("recRegistroCitas_PA", lObjRespuesta);
        }
    }
}