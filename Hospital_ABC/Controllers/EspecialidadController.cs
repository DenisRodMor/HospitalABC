using Entidades;
using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Hospital_ABC.Controllers
{
    public class EspecialidadController : Controller
    {


        private readonly Logger gobjLogger = LogManager.GetCurrentClassLogger();

        public ActionResult  recEspecialidad_PA()
        {
            List<PA_Especialidad_MostrarDetalle_Result> lObjRespuesta = new List<PA_Especialidad_MostrarDetalle_Result>();
            try
            {
                using (srvEspecialidad.IsrvEspecialidadClient srvHospital = new srvEspecialidad.IsrvEspecialidadClient())
                {
                    lObjRespuesta = srvHospital.recEspecialidad_PA();
                }
            }
            catch (Exception ex)
            {

                gobjLogger.Error("Se produjo un error. Detalle " + ex.Message + " " + ex.InnerException.Message);
                throw ex;
            }
            return View(lObjRespuesta);
        }

        public ActionResult AgregaEspecialidad_PA()
        {


            return View();
        }

        public ActionResult ModificaEspecialidad_PA(int id)
        {
            PA_Especialidad_MostrarDetallexid_Result lObjRespuesta = new PA_Especialidad_MostrarDetallexid_Result();
            try
            {
                using (srvEspecialidad.IsrvEspecialidadClient srvHospital = new srvEspecialidad.IsrvEspecialidadClient())
                {
                    lObjRespuesta = srvHospital.recEspecialidadXID_PA(id);
                }
            }
            catch (Exception ex)
            {
                gobjLogger.Error("Se produjo un error. Detalle " + ex.Message + " " + ex.InnerException.Message);
                throw ex;
            }
            return View(lObjRespuesta);

        }

        public ActionResult EliminarEspecialidad_PA(int id)
        {
            PA_Especialidad_MostrarDetallexid_Result lObjRespuesta = new PA_Especialidad_MostrarDetallexid_Result();
            try
            {
                using (srvEspecialidad.IsrvEspecialidadClient srvHospital = new srvEspecialidad.IsrvEspecialidadClient())
                {
                    lObjRespuesta = srvHospital.recEspecialidadXID_PA(id);
                }
            }
            catch (Exception ex)
            {
                gobjLogger.Error("Se produjo un error. Detalle " + ex.Message + " " + ex.InnerException.Message);
                throw ex;
            }
            return View(lObjRespuesta);

        }

        public ActionResult DetalleEspecialidad_PA(int id)
        {
            PA_Especialidad_MostrarDetallexid_Result lObjRespuesta = new PA_Especialidad_MostrarDetallexid_Result();
            try
            {
                using (srvEspecialidad.IsrvEspecialidadClient srvHospital = new srvEspecialidad.IsrvEspecialidadClient())
                {
                    lObjRespuesta = srvHospital.recEspecialidadXID_PA(id);
                }
            }
            catch (Exception ex)
            {
                gobjLogger.Error("Se produjo un error. Detalle " + ex.Message + " " + ex.InnerException.Message);
                throw ex;
            }
            return View(lObjRespuesta);

        }

        public ActionResult AccionesEntidades(string submitButton, Especialidades pEspecialidad)
        {
            try
            {
                switch (submitButton)
                {
                    case "Agregar":
                        return insertarEspecialidad(pEspecialidad);
                    case "Actualizar":
                        return modificarEspecialidad(pEspecialidad);
                    case "Eliminar":
                        return eliminarEspecialidad(pEspecialidad);
                    default:
                        return RedirectToAction("recEspecialidad_PA");
                }
            }
            catch (Exception ex)
            {
                gobjLogger.Error("Se produjo un error. Detalle " + ex.Message + " " + ex.InnerException.Message);
                throw ex;
            }
        }

        public ActionResult insertarEspecialidad(Especialidades pEspecialidad)
        {
            List<PA_Especialidad_MostrarDetalle_Result> lObjRespuesta = new List<PA_Especialidad_MostrarDetalle_Result>();

            try
            {
                using (srvEspecialidad.IsrvEspecialidadClient srvHospital = new srvEspecialidad.IsrvEspecialidadClient())
                {

                    if (srvHospital.insEspecialidad_PA(pEspecialidad))
                    {

                    }

                    lObjRespuesta = srvHospital.recEspecialidad_PA();
                }
            }
            catch (Exception ex)
            {
                gobjLogger.Error("Se produjo un error. Detalle " + ex.Message + " " + ex.InnerException.Message);
                throw ex;
            }
            return View("recEspecialidad_PA", lObjRespuesta);
        }

        public ActionResult modificarEspecialidad(Especialidades pEspecialidad)
        {
            List<PA_Especialidad_MostrarDetalle_Result> lObjRespuesta = new List<PA_Especialidad_MostrarDetalle_Result>();

            try
            {
                using (srvEspecialidad.IsrvEspecialidadClient srvHospital = new srvEspecialidad.IsrvEspecialidadClient())
                {

                    if (srvHospital.modEspecialidad_PA(pEspecialidad))
                    {

                    }

                    lObjRespuesta = srvHospital.recEspecialidad_PA();
                }
            }
            catch (Exception ex)
            {
                gobjLogger.Error("Se produjo un error. Detalle " + ex.Message + " " + ex.InnerException.Message);
                throw ex;
            }
            return View("recEspecialidad_PA", lObjRespuesta);
        }

        public ActionResult eliminarEspecialidad(Especialidades pEspecialidad)
        {
            List<PA_Especialidad_MostrarDetalle_Result> lObjRespuesta = new List<PA_Especialidad_MostrarDetalle_Result>();

            try
            {
                using (srvEspecialidad.IsrvEspecialidadClient srvHospital = new srvEspecialidad.IsrvEspecialidadClient())
                {

                    if (srvHospital.delEspecialidad_PA(pEspecialidad))
                    {

                    }

                    lObjRespuesta = srvHospital.recEspecialidad_PA();
                }
            }
            catch (Exception ex)
            {
                gobjLogger.Error("Se produjo un error. Detalle " + ex.Message + " " + ex.InnerException.Message);
                throw ex;
            }
            return View("recEspecialidad_PA", lObjRespuesta);
        }
    }
}