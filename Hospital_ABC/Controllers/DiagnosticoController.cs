using Entidades;
using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Hospital_ABC.Controllers
{
    public class DiagnosticoController : Controller
    {

        private readonly Logger gobjLogger = LogManager.GetCurrentClassLogger();

        public ActionResult recDiagnostico_PA()
        {
            List<PA_Diagnostico_MostrarDetalle_Result> lObjRespuesta = new List<PA_Diagnostico_MostrarDetalle_Result>();
            try
            {
                using (srvDiagnostico.IsrvDiagnosticoClient srvHospital = new srvDiagnostico.IsrvDiagnosticoClient())
                {
                    lObjRespuesta = srvHospital.recDiagnostico_PA();
                }
            }
            catch (Exception ex)
            {

                gobjLogger.Error("Se produjo un error. Detalle " + ex.Message + " " + ex.InnerException.Message);
                throw ex;
            }
            return View(lObjRespuesta);
        }



        public ActionResult AgregaDiagnostico_PA()
        {


            return View();
        }

        public ActionResult ModificaDiagnostico_PA(int id)
        {
            PA_Diagnostico_MostrarDetallexid_Result lObjRespuesta = new PA_Diagnostico_MostrarDetallexid_Result();
            try
            {
                using (srvDiagnostico.IsrvDiagnosticoClient srvHospital = new srvDiagnostico.IsrvDiagnosticoClient())
                {
                    lObjRespuesta = srvHospital.recDiagnosticoXID_PA(id);
                }
            }
            catch (Exception ex)
            {
                gobjLogger.Error("Se produjo un error. Detalle " + ex.Message + " " + ex.InnerException.Message);
                throw ex;
            }
            return View(lObjRespuesta);

        }

        public ActionResult EliminarDiagnostico_PA(int id)
        {

            PA_Diagnostico_MostrarDetallexid_Result lObjRespuesta = new PA_Diagnostico_MostrarDetallexid_Result();
            try
            {
                using (srvDiagnostico.IsrvDiagnosticoClient srvHospital = new srvDiagnostico.IsrvDiagnosticoClient())
                {
                    lObjRespuesta = srvHospital.recDiagnosticoXID_PA(id);
                }
            }
            catch (Exception ex)
            {
                gobjLogger.Error("Se produjo un error. Detalle " + ex.Message + " " + ex.InnerException.Message);
                throw ex;
            }
            return View(lObjRespuesta);

        }

        public ActionResult DetalleDiagnostico_PA(int id)
        {

            PA_Diagnostico_MostrarDetallexid_Result lObjRespuesta = new PA_Diagnostico_MostrarDetallexid_Result();
            try
            {
                using (srvDiagnostico.IsrvDiagnosticoClient srvHospital = new srvDiagnostico.IsrvDiagnosticoClient())
                {
                    lObjRespuesta = srvHospital.recDiagnosticoXID_PA(id);
                }
            }
            catch (Exception ex)
            {
                gobjLogger.Error("Se produjo un error. Detalle " + ex.Message + " " + ex.InnerException.Message);
                throw ex;
            }
            return View(lObjRespuesta);

        }

        public ActionResult AccionesEntidades(string submitButton, Diagnostico pDiagnostico)
        {
            try
            {
                switch (submitButton)
                {
                    case "Agregar":
                        return insertarDiagnostico(pDiagnostico);
                    case "Actualizar":
                        return modificarDiagnostico(pDiagnostico);
                    case "Eliminar":
                        return eliminarDiagnostico(pDiagnostico);
                    default:
                        return RedirectToAction("recDiagnostico_PA");
                }
            }
            catch (Exception ex)
            {
                gobjLogger.Error("Se produjo un error. Detalle " + ex.Message + " " + ex.InnerException.Message);
                throw ex;
            }
        }

        public ActionResult insertarDiagnostico(Diagnostico pDiagnostico)
        {
            List<PA_Diagnostico_MostrarDetalle_Result> lObjRespuesta = new List<PA_Diagnostico_MostrarDetalle_Result>();

            try
            {
                using (srvDiagnostico.IsrvDiagnosticoClient srvHospital = new srvDiagnostico.IsrvDiagnosticoClient())
                {

                    if (srvHospital.insDiagnostico_PA(pDiagnostico))
                    {

                    }

                    lObjRespuesta = srvHospital.recDiagnostico_PA();
                }
            }
            catch (Exception ex)
            {
                gobjLogger.Error("Se produjo un error. Detalle " + ex.Message + " " + ex.InnerException.Message);
                throw ex;
            }
            return View("recDiagnostico_PA", lObjRespuesta);
        }

        public ActionResult modificarDiagnostico(Diagnostico pDiagnostico)
        {
            List<PA_Diagnostico_MostrarDetalle_Result> lObjRespuesta = new List<PA_Diagnostico_MostrarDetalle_Result>();

            try
            {
                using (srvDiagnostico.IsrvDiagnosticoClient srvHospital = new srvDiagnostico.IsrvDiagnosticoClient())
                {

                    if (srvHospital.modDiagnostico_PA(pDiagnostico))
                    {

                    }

                    lObjRespuesta = srvHospital.recDiagnostico_PA();
                }
            }
            catch (Exception ex)
            {
                gobjLogger.Error("Se produjo un error. Detalle " + ex.Message + " " + ex.InnerException.Message);
                throw ex;
            }
            return View("recDiagnostico_PA", lObjRespuesta);
        }

        public ActionResult eliminarDiagnostico(Diagnostico pDiagnostico)
        {
            List<PA_Diagnostico_MostrarDetalle_Result> lObjRespuesta = new List<PA_Diagnostico_MostrarDetalle_Result>();

            try
            {
                using (srvDiagnostico.IsrvDiagnosticoClient srvHospital = new srvDiagnostico.IsrvDiagnosticoClient())
                {

                    if (srvHospital.delDiagnostico_PA(pDiagnostico))
                    {

                    }

                    lObjRespuesta = srvHospital.recDiagnostico_PA();
                }
            }
            catch (Exception ex)
            {
                gobjLogger.Error("Se produjo un error. Detalle " + ex.Message + " " + ex.InnerException.Message);
                throw ex;
            }
            return View("recDiagnostico_PA", lObjRespuesta);
        }
    }
}