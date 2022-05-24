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
    public class RegistroCitasController : ApiController
    {
        private readonly Logger gobjLogger = LogManager.GetCurrentClassLogger();
        private readonly IRegistroCitasLN oRegistroCitas = new RegistroCitasLN();


        [HttpGet]
        public List<PA_RegistroCitas_MostrarDetalle_Result> recRegistroCitas_PA()
        {
            List<PA_RegistroCitas_MostrarDetalle_Result> lObjRespuesta = new List<PA_RegistroCitas_MostrarDetalle_Result>();
            try
            {
                lObjRespuesta = oRegistroCitas.recRegistroCitas_PA();
            }
            catch (Exception ex)
            {
                gobjLogger.Error("Se produjo un error. Detalle " + ex.Message + " " + ex.InnerException.Message);
                throw ex;
            }
            return lObjRespuesta;
        }

        [HttpGet]
        public PA_RegistroCitas_MostrarDetallexid_Result recRegistroCitasXID_PA(int id)
        {
            PA_RegistroCitas_MostrarDetallexid_Result lObjRespuesta = new PA_RegistroCitas_MostrarDetallexid_Result();
            try
            {
                lObjRespuesta = oRegistroCitas.recRegistroCitasXID_PA(id);
            }
            catch (Exception ex)
            {
                gobjLogger.Error("Se produjo un error. Detalle " + ex.Message + " " + ex.InnerException.Message);
                throw ex;
            }
            return lObjRespuesta;
        }

        [HttpPost]
        public IHttpActionResult insRegistroCitas_PA([FromBody] RegistroCitas pRegistroCitas)
        {
            if (ModelState.IsValid)
            {
                oRegistroCitas.insRegistroCitas_PA(pRegistroCitas);
                return Ok(pRegistroCitas);
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
        public IHttpActionResult modRegistroCitas_PA([FromBody] RegistroCitas pRegistroCitas)
        {
            if (ModelState.IsValid)
            {
                oRegistroCitas.modRegistroCitas_PA(pRegistroCitas);
                return Ok(pRegistroCitas);
            }
            else
            {
                return BadRequest();
            }


        }


        [HttpDelete]
        public IHttpActionResult delRegistroCitas_PA([FromBody] RegistroCitas pRegistroCitas)
        {
            if (ModelState.IsValid)
            {
                oRegistroCitas.delRegistroCitas_PA(pRegistroCitas);
                return Ok(pRegistroCitas);
            }
            else
            {
                return BadRequest();
            }


        }

    }
}