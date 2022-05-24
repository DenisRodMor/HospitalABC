using Entidades;
using LogicaNegocio.Implementacion;
using LogicaNegocio.Interfaces;
using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace webApi.Controllers
{
    public class PacientesController : ApiController
    {
       private readonly Logger gobjLogger = LogManager.GetCurrentClassLogger();
        private readonly IPacientesLN opacientes = new PacientesLN();

        [HttpGet]
        public List<PA_Pacientes_MostrarDetalle_Result> recPacientes_PA()
        {
            List<PA_Pacientes_MostrarDetalle_Result> lObjRespuesta = new List<PA_Pacientes_MostrarDetalle_Result>();
            try
            {
                lObjRespuesta = opacientes.recPacientes_PA();
            }
            catch (Exception ex)
            {
                gobjLogger.Error("Se produjo un error. Detalle " + ex.Message + " " + ex.InnerException.Message);
                throw ex;
            }
            return lObjRespuesta;
        }

        [HttpGet]
        public PA_Pacientes_MostrarDetallexid_Result recPacientesXID_PA(int id)
        {
            PA_Pacientes_MostrarDetallexid_Result lObjRespuesta = new PA_Pacientes_MostrarDetallexid_Result();
            try
            {
                lObjRespuesta = opacientes.recPacientesXID_PA(id);
            }
            catch (Exception ex)
            {
                gobjLogger.Error("Se produjo un error. Detalle " + ex.Message + " " + ex.InnerException.Message);
                throw ex;
            }
            return lObjRespuesta;
        }

        [HttpPost]
        public IHttpActionResult insPacientes_PA([FromBody]Paciente pPaciente)
        {
            if (ModelState.IsValid)
            {
                opacientes.insPacientes_PA(pPaciente);
                return Ok(pPaciente);
            }
            else
            {
                return BadRequest();
            }

            //bool lObjRespuesta = false;
            //try
            //{
            //    lObjRespuesta = opacientes.insPacientes_PA(pPaciente);
            //}
            //catch (Exception ex)
            //{
            //    gobjLogger.Error("Se produjo un error. Detalle " + ex.Message + " " + ex.InnerException.Message);
            //    throw ex;
            //}
            //return lObjRespuesta;
        }

        [HttpPut]
        public IHttpActionResult modPacientes_PA([FromBody] Paciente pPaciente)
        {
            if (ModelState.IsValid)
            {
                opacientes.modPacientes_PA(pPaciente);
                return Ok(pPaciente);
            }
            else
            {
                return BadRequest();
            }

          
        }


        [HttpDelete]
        public IHttpActionResult delPacientes_PA([FromBody] Paciente pPaciente)
        {
            if (ModelState.IsValid)
            {
                opacientes.delPacientes_PA(pPaciente);
                return Ok(pPaciente);
            }
            else
            {
                return BadRequest();
            }


        }
    }
}
