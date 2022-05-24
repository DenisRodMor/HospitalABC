using Entidades;
using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Hospital_ABC.Controllers
{
    public class MedicoEspecialistaController : Controller
    {



        private readonly Logger gobjLogger = LogManager.GetCurrentClassLogger();

        public ActionResult recMedicoEspecialista_PA()
        {
            List<PA_MedicoEspecialista_MostrarDetalle_Result> lObjRespuesta = new List<PA_MedicoEspecialista_MostrarDetalle_Result>();
            try
            {
                using (srvMedicoEspecialista.IsrvMedicoEspecialistaClient srvhospital = new srvMedicoEspecialista.IsrvMedicoEspecialistaClient())
                {
                    lObjRespuesta = srvhospital.recMedicoEspecialista_PA();
                }
            }
            catch (Exception ex)
            {

                gobjLogger.Error("Se produjo un error. Detalle " + ex.Message + " " + ex.InnerException.Message);
                throw ex;
            }
            return View(lObjRespuesta);
        }

        public ActionResult AgregaMedicoEspecialista_PA()
        {


            return View();
        }

        public ActionResult ModificaMedicoEspecialista_PA(int id)
        {
            PA_MedicoEspecialista_MostrarDetallexid_Result lObjRespuesta = new PA_MedicoEspecialista_MostrarDetallexid_Result();
            try
            {
                using (srvMedicoEspecialista.IsrvMedicoEspecialistaClient srvHospital = new srvMedicoEspecialista.IsrvMedicoEspecialistaClient())
                {
                    lObjRespuesta = srvHospital.recMedicoEspecialistaXID_PA(id);
                }
            }
            catch (Exception ex)
            {
                gobjLogger.Error("Se produjo un error. Detalle " + ex.Message + " " + ex.InnerException.Message);
                throw ex;
            }
            return View(lObjRespuesta);

        }

        public ActionResult EliminarMedicoEspecialista_PA(int id)
        {
            PA_MedicoEspecialista_MostrarDetallexid_Result lObjRespuesta = new PA_MedicoEspecialista_MostrarDetallexid_Result();
            try
            {
                using (srvMedicoEspecialista.IsrvMedicoEspecialistaClient srvHospital = new srvMedicoEspecialista.IsrvMedicoEspecialistaClient())
                {
                    lObjRespuesta = srvHospital.recMedicoEspecialistaXID_PA(id);
                }
            }
            catch (Exception ex)
            {
                gobjLogger.Error("Se produjo un error. Detalle " + ex.Message + " " + ex.InnerException.Message);
                throw ex;
            }
            return View(lObjRespuesta);

        }

        public ActionResult DetalleMedicoEspecialista_PA(int id)
        {
            PA_MedicoEspecialista_MostrarDetallexid_Result lObjRespuesta = new PA_MedicoEspecialista_MostrarDetallexid_Result();
            try
            {
                using (srvMedicoEspecialista.IsrvMedicoEspecialistaClient srvHospital = new srvMedicoEspecialista.IsrvMedicoEspecialistaClient())
                {
                    lObjRespuesta = srvHospital.recMedicoEspecialistaXID_PA(id);
                }
            }
            catch (Exception ex)
            {
                gobjLogger.Error("Se produjo un error. Detalle " + ex.Message + " " + ex.InnerException.Message);
                throw ex;
            }
            return View(lObjRespuesta);

        }

        public ActionResult AccionesEntidades(string submitButton, MedicoEspecialista pMedicoEspecialista)
        {
            try
            {
                switch (submitButton)
                {
                    case "Agregar":
                        return insertarMedicoEspecialista(pMedicoEspecialista);
                    case "Actualizar":
                        return modificarMedicoEspecialista(pMedicoEspecialista);
                    case "Eliminar":
                        return eliminarMedicoEspecialista(pMedicoEspecialista);
                    default:
                        return RedirectToAction("recMedicoEspecialista_PA");
                }
            }
            catch (Exception ex)
            {
                gobjLogger.Error("Se produjo un error. Detalle " + ex.Message + " " + ex.InnerException.Message);
                throw ex;
            }
        }

        public ActionResult insertarMedicoEspecialista(MedicoEspecialista pMedicoEspecialista)
        {
            List<PA_MedicoEspecialista_MostrarDetalle_Result> lObjRespuesta = new List<PA_MedicoEspecialista_MostrarDetalle_Result>();

            try
            {
                using (srvMedicoEspecialista.IsrvMedicoEspecialistaClient srvHospital = new srvMedicoEspecialista.IsrvMedicoEspecialistaClient())
                {

                    if (srvHospital.insMedicoEspecialista_PA(pMedicoEspecialista))
                    {

                    }

                    lObjRespuesta = srvHospital.recMedicoEspecialista_PA();
                }
            }
            catch (Exception ex)
            {
                gobjLogger.Error("Se produjo un error. Detalle " + ex.Message + " " + ex.InnerException.Message);
                throw ex;
            }
            return View("recMedicoEspecialista_PA", lObjRespuesta);
        }

        public ActionResult modificarMedicoEspecialista(MedicoEspecialista pMedicoEspecialista)
        {
            List<PA_MedicoEspecialista_MostrarDetalle_Result> lObjRespuesta = new List<PA_MedicoEspecialista_MostrarDetalle_Result>();

            try
            {
                using (srvMedicoEspecialista.IsrvMedicoEspecialistaClient srvHospital = new srvMedicoEspecialista.IsrvMedicoEspecialistaClient())
                {

                    if (srvHospital.modMedicoEspecialista_PA(pMedicoEspecialista))
                    {

                    }

                    lObjRespuesta = srvHospital.recMedicoEspecialista_PA();
                }
            }
            catch (Exception ex)
            {
                gobjLogger.Error("Se produjo un error. Detalle " + ex.Message + " " + ex.InnerException.Message);
                throw ex;
            }
            return View("recMedicoEspecialista_PA", lObjRespuesta);
        }

        public ActionResult eliminarMedicoEspecialista(MedicoEspecialista pMedicoEspecialista)
        {
            List<PA_MedicoEspecialista_MostrarDetalle_Result> lObjRespuesta = new List<PA_MedicoEspecialista_MostrarDetalle_Result>();

            try
            {
                using (srvMedicoEspecialista.IsrvMedicoEspecialistaClient srvHospital = new srvMedicoEspecialista.IsrvMedicoEspecialistaClient())
                {

                    if (srvHospital.delMedicoEspecialista_PA(pMedicoEspecialista))
                    {

                    }

                    lObjRespuesta = srvHospital.recMedicoEspecialista_PA();
                }
            }
            catch (Exception ex)
            {
                gobjLogger.Error("Se produjo un error. Detalle " + ex.Message + " " + ex.InnerException.Message);
                throw ex;
            }
            return View("recMedicoEspecialista_PA", lObjRespuesta);
        }


    }
}