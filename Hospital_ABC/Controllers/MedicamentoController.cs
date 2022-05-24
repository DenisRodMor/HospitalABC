using Entidades;
using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Hospital_ABC.Controllers
{
    public class MedicamentoController : Controller
    {

        private readonly Logger gobjLogger = LogManager.GetCurrentClassLogger();

        public ActionResult recMedicamentos_PA()
        {
            List< PA_Medicamentos_MostrarDetalle_Result> lObjRespuesta = new List<PA_Medicamentos_MostrarDetalle_Result>();
            try
            {
                using (srvMedicamento.IsrvMedicamentoClient srvhospital = new srvMedicamento.IsrvMedicamentoClient())
                {
                    lObjRespuesta = srvhospital.recMedicamentos_PA();
                }
            }
            catch (Exception ex)
            {

                gobjLogger.Error("Se produjo un error. Detalle " + ex.Message + " " + ex.InnerException.Message);
                throw ex;
            }
            return View(lObjRespuesta);
        }

        public ActionResult AgregaMedicamentos_PA()
        {


            return View();
        }

        public ActionResult ModificaMedicamentos_PA(int id)
        {
            PA_Medicamentos_MostrarDetallexid_Result lObjRespuesta = new PA_Medicamentos_MostrarDetallexid_Result();
            try
            {
                using (srvMedicamento.IsrvMedicamentoClient srvHospital = new srvMedicamento.IsrvMedicamentoClient())
                {
                    lObjRespuesta = srvHospital.recMedicamentosXID_PA(id);
                }
            }
            catch (Exception ex)
            {
                gobjLogger.Error("Se produjo un error. Detalle " + ex.Message + " " + ex.InnerException.Message);
                throw ex;
            }
            return View(lObjRespuesta);

        }

        public ActionResult EliminarMedicamentos_PA(int id)
        {
            PA_Medicamentos_MostrarDetallexid_Result lObjRespuesta = new PA_Medicamentos_MostrarDetallexid_Result();
            try
            {
                using (srvMedicamento.IsrvMedicamentoClient srvHospital = new srvMedicamento.IsrvMedicamentoClient())
                {
                    lObjRespuesta = srvHospital.recMedicamentosXID_PA(id);
                }
            }
            catch (Exception ex)
            {
                gobjLogger.Error("Se produjo un error. Detalle " + ex.Message + " " + ex.InnerException.Message);
                throw ex;
            }
            return View(lObjRespuesta);

        }

        public ActionResult DetalleMedicamentos_PA(int id)
        {
            PA_Medicamentos_MostrarDetallexid_Result lObjRespuesta = new PA_Medicamentos_MostrarDetallexid_Result();
            try
            {
                using (srvMedicamento.IsrvMedicamentoClient srvHospital = new srvMedicamento.IsrvMedicamentoClient())
                {
                    lObjRespuesta = srvHospital.recMedicamentosXID_PA(id);
                }
            }
            catch (Exception ex)
            {
                gobjLogger.Error("Se produjo un error. Detalle " + ex.Message + " " + ex.InnerException.Message);
                throw ex;
            }
            return View(lObjRespuesta);

        }

        public ActionResult AccionesEntidades(string submitButton, Medicamento pMedicamento)
        {
            try
            {
                switch (submitButton)
                {
                    case "Agregar":
                        return insertarMedicamento(pMedicamento);
                    case "Actualizar":
                        return modificarMedicamento(pMedicamento);
                    case "Eliminar":
                        return eliminarMedicamento(pMedicamento);
                    default:
                        return RedirectToAction("recMedicamentos_PA");
                }
            }
            catch (Exception ex)
            {
                gobjLogger.Error("Se produjo un error. Detalle " + ex.Message + " " + ex.InnerException.Message);
                throw ex;
            }
        }

        public ActionResult insertarMedicamento(Medicamento pMedicamento)
        {
            List<PA_Medicamentos_MostrarDetalle_Result> lObjRespuesta = new List<PA_Medicamentos_MostrarDetalle_Result>();

            try
            {
                using (srvMedicamento.IsrvMedicamentoClient srvHospital = new srvMedicamento.IsrvMedicamentoClient())
                {

                    if (srvHospital.insMedicamentos_PA(pMedicamento))
                    {

                    }

                    lObjRespuesta = srvHospital.recMedicamentos_PA();
                }
            }
            catch (Exception ex)
            {
                gobjLogger.Error("Se produjo un error. Detalle " + ex.Message + " " + ex.InnerException.Message);
                throw ex;
            }
            return View("recMedicamentos_PA", lObjRespuesta);
        }

        public ActionResult modificarMedicamento(Medicamento pMedicamento)
        {
            List<PA_Medicamentos_MostrarDetalle_Result> lObjRespuesta = new List<PA_Medicamentos_MostrarDetalle_Result>();

            try
            {
                using (srvMedicamento.IsrvMedicamentoClient srvHospital = new srvMedicamento.IsrvMedicamentoClient())
                {

                    if (srvHospital.modMedicamentos_PA(pMedicamento))
                    {

                    }

                    lObjRespuesta = srvHospital.recMedicamentos_PA();
                }
            }
            catch (Exception ex)
            {
                gobjLogger.Error("Se produjo un error. Detalle " + ex.Message + " " + ex.InnerException.Message);
                throw ex;
            }
            return View("recMedicamentos_PA", lObjRespuesta);
        }

        public ActionResult eliminarMedicamento(Medicamento pMedicamento)
        {
            List<PA_Medicamentos_MostrarDetalle_Result> lObjRespuesta = new List<PA_Medicamentos_MostrarDetalle_Result>();

            try
            {
                using (srvMedicamento.IsrvMedicamentoClient srvHospital = new srvMedicamento.IsrvMedicamentoClient())
                {

                    if (srvHospital.delMedicamentos_PA(pMedicamento))
                    {

                    }

                    lObjRespuesta = srvHospital.recMedicamentos_PA();
                }
            }
            catch (Exception ex)
            {
                gobjLogger.Error("Se produjo un error. Detalle " + ex.Message + " " + ex.InnerException.Message);
                throw ex;
            }
            return View("recMedicamentos_PA", lObjRespuesta);
        }


    }
}