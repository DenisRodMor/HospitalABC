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
    public class EspecialidadController : ApiController
    {
        private readonly Logger gobjLogger = LogManager.GetCurrentClassLogger();
        private readonly IEspecialidadLN oEspecialidad = new EspecialidadLN();

        [HttpGet]
        public List<PA_Especialidad_MostrarDetalle_Result> recEspecialidad_PA()
        {
            List<PA_Especialidad_MostrarDetalle_Result> lObjRespuesta = new List<PA_Especialidad_MostrarDetalle_Result>();
            try
            {
                lObjRespuesta = oEspecialidad.recEspecialidad_PA();
            }
            catch (Exception ex)
            {
                gobjLogger.Error("Se produjo un error. Detalle " + ex.Message + " " + ex.InnerException.Message);
                throw ex;
            }
            return lObjRespuesta;
        }

        [HttpGet]
        public PA_Especialidad_MostrarDetallexid_Result recEspecialidadXID_PA(int id)
        {
            PA_Especialidad_MostrarDetallexid_Result lObjRespuesta = new PA_Especialidad_MostrarDetallexid_Result();
            try
            {
                lObjRespuesta = oEspecialidad.recEspecialidadXID_PA(id);
            }
            catch (Exception ex)
            {
                gobjLogger.Error("Se produjo un error. Detalle " + ex.Message + " " + ex.InnerException.Message);
                throw ex;
            }
            return lObjRespuesta;
        }

        [HttpPost]
        public IHttpActionResult insEspecialidad_PA([FromBody] Especialidades pEspecialidad)
        {
            if (ModelState.IsValid)
            {
                oEspecialidad.insEspecialidad_PA(pEspecialidad);
                return Ok(pEspecialidad);
            }
            else
            {
                return BadRequest();
            }

        }

        [HttpPut]
        public IHttpActionResult modEspecialidad_PA([FromBody] Especialidades pEspecialidad)
        {
            if (ModelState.IsValid)
            {
                oEspecialidad.modEspecialidad_PA(pEspecialidad);
                return Ok(pEspecialidad);
            }
            else
            {
                return BadRequest();
            }


        }


        [HttpDelete]
        public IHttpActionResult delEspecialidad_PA([FromBody] Especialidades pEspecialidad)
        {
            if (ModelState.IsValid)
            {
                oEspecialidad.delEspecialidad_PA(pEspecialidad);
                return Ok(pEspecialidad);
            }
            else
            {
                return BadRequest();
            }


        }
    }
}