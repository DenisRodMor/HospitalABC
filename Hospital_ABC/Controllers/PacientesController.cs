using Entidades;
using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Hospital_ABC.Controllers
{
    public class PacientesController : Controller
    {

        private readonly Logger gobjLogger = LogManager.GetCurrentClassLogger();
            
        public ActionResult recPacientes_PA()
        {

            List<PA_Pacientes_MostrarDetalle_Result> lObjRespuesta = new List<PA_Pacientes_MostrarDetalle_Result>();
            try
            {
                using (srvPacientes.IsrvPacientesClient srvHospital=new srvPacientes.IsrvPacientesClient ())
                {
                    lObjRespuesta = srvHospital.recPacientes_PA();
                }
            }
            catch (Exception ex)
            {
                gobjLogger.Error("Se produjo un error. Detalle " + ex.Message + " " + ex.InnerException.Message);
                throw ex;
            }
            return View(lObjRespuesta);
        }

        public ActionResult AgregaPacientes_PA()
        {


            return View();
        }

        public ActionResult ModificaPacientes_PA(int id)
        {
              PA_Pacientes_MostrarDetallexid_Result lObjRespuesta = new PA_Pacientes_MostrarDetallexid_Result();
            try
            {
                using (srvPacientes.IsrvPacientesClient srvHospital = new srvPacientes.IsrvPacientesClient())
                {
                    lObjRespuesta = srvHospital.recPacientesXID_PA(id);
                }
            }
            catch (Exception ex)
            {
                gobjLogger.Error("Se produjo un error. Detalle " + ex.Message + " " + ex.InnerException.Message);
                throw ex;
            }
            return View(lObjRespuesta);

        }

        public ActionResult EliminarPacientes_PA(int id)
        {
            PA_Pacientes_MostrarDetallexid_Result lObjRespuesta = new PA_Pacientes_MostrarDetallexid_Result();
            try
            {
                using (srvPacientes.IsrvPacientesClient srvHospital = new srvPacientes.IsrvPacientesClient())
                {
                    lObjRespuesta = srvHospital.recPacientesXID_PA(id);
                }
            }
            catch (Exception ex)
            {
                gobjLogger.Error("Se produjo un error. Detalle " + ex.Message + " " + ex.InnerException.Message);
                throw ex;
            }
            return View(lObjRespuesta);

        }

        public ActionResult DetallePacientes_PA(int id)
        {
            PA_Pacientes_MostrarDetallexid_Result lObjRespuesta = new PA_Pacientes_MostrarDetallexid_Result();
            try
            {
                using (srvPacientes.IsrvPacientesClient srvHospital = new srvPacientes.IsrvPacientesClient())
                {
                    lObjRespuesta = srvHospital.recPacientesXID_PA(id);
                }
            }
            catch (Exception ex)
            {
                gobjLogger.Error("Se produjo un error. Detalle " + ex.Message + " " + ex.InnerException.Message);
                throw ex;
            }
            return View(lObjRespuesta);

        }

        public ActionResult AccionesEntidades(string submitButton, Paciente ppaciente)
        {
            try
            {
                switch (submitButton)
                {
                    case "Agregar":
                        return insertarPacientes(ppaciente);
                    case "Actualizar":
                        return modificarPacientes(ppaciente);
                    case "Eliminar":
                        return eliminarPacientes(ppaciente);
                    default:
                        return RedirectToAction("recPacientes_PA");
                }
            }
            catch (Exception ex)
            {
                gobjLogger.Error("Se produjo un error. Detalle " + ex.Message + " " + ex.InnerException.Message);
                throw ex;
            }
        }

        public ActionResult insertarPacientes( Paciente ppaciente)
        {
            List<PA_Pacientes_MostrarDetalle_Result> lObjRespuesta = new List<PA_Pacientes_MostrarDetalle_Result>();

            try
            {
                using (srvPacientes.IsrvPacientesClient srvHospital = new srvPacientes.IsrvPacientesClient())
                {

                    if (srvHospital.insPacientes_PA(ppaciente))
                    {

                    }

                    lObjRespuesta = srvHospital.recPacientes_PA();
                }
            }
            catch (Exception ex)
            {
                gobjLogger.Error("Se produjo un error. Detalle " + ex.Message + " " + ex.InnerException.Message);
                throw ex;
            }
            return View("recPacientes_PA", lObjRespuesta);
        }

        public ActionResult modificarPacientes( Paciente ppaciente)
        {
            List<PA_Pacientes_MostrarDetalle_Result> lObjRespuesta = new List<PA_Pacientes_MostrarDetalle_Result>();

            try
            {
                using (srvPacientes.IsrvPacientesClient srvHospital = new srvPacientes.IsrvPacientesClient())
                {

                    if (srvHospital.modPacientes_PA(ppaciente))
                    {

                    }

                    lObjRespuesta = srvHospital.recPacientes_PA();
                }
            }
            catch (Exception ex)
            {
                gobjLogger.Error("Se produjo un error. Detalle " + ex.Message + " " + ex.InnerException.Message);
                throw ex;
            }
            return View("recPacientes_PA", lObjRespuesta);
        }

        public ActionResult eliminarPacientes(Paciente ppaciente)
        {
            List<PA_Pacientes_MostrarDetalle_Result> lObjRespuesta = new List<PA_Pacientes_MostrarDetalle_Result>();

            try
            {
                using (srvPacientes.IsrvPacientesClient srvHospital = new srvPacientes.IsrvPacientesClient())
                {

                    if (srvHospital.delPacientes_PA(ppaciente))
                    {

                    }

                    lObjRespuesta = srvHospital.recPacientes_PA();
                }
            }
            catch (Exception ex)
            {
                gobjLogger.Error("Se produjo un error. Detalle " + ex.Message + " " + ex.InnerException.Message);
                throw ex;
            }
            return View("recPacientes_PA", lObjRespuesta);
        }
    }
}