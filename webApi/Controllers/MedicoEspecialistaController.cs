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
    public class MedicoEspecialistaController : ApiController
    {
        private readonly Logger gobjLogger = LogManager.GetCurrentClassLogger();
        private readonly IMedicoEspecialistaLN oMedicoEspecialista = new MedicoEspecialistaLN();

        [HttpGet]
        public List<PA_MedicoEspecialista_MostrarDetalle_Result> recMedicoEspecialista_PA()
        {
            List<PA_MedicoEspecialista_MostrarDetalle_Result> lObjRespuesta = new List<PA_MedicoEspecialista_MostrarDetalle_Result>();
            try
            {
                lObjRespuesta = oMedicoEspecialista.recMedicoEspecialista_PA();
            }
            catch (Exception ex)
            {
                gobjLogger.Error("Se produjo un error. Detalle " + ex.Message + " " + ex.InnerException.Message);
                throw ex;
            }
            return lObjRespuesta;
        }

        [HttpGet]
        public PA_MedicoEspecialista_MostrarDetallexid_Result recMedicoEspecialistaXID_PA(int id)
        {
            PA_MedicoEspecialista_MostrarDetallexid_Result lObjRespuesta = new PA_MedicoEspecialista_MostrarDetallexid_Result();
            try
            {
                lObjRespuesta = oMedicoEspecialista.recMedicoEspecialistaXID_PA(id);
            }
            catch (Exception ex)
            {
                gobjLogger.Error("Se produjo un error. Detalle " + ex.Message + " " + ex.InnerException.Message);
                throw ex;
            }
            return lObjRespuesta;
        }


        [HttpPost]
        public IHttpActionResult insMedicoEspecialista_PA([FromBody] MedicoEspecialista pMedicoEspecialista)
        {
            if (ModelState.IsValid)
            {
                oMedicoEspecialista.insMedicoEspecialista_PA(pMedicoEspecialista);
                return Ok(pMedicoEspecialista);
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
        public IHttpActionResult modMedicoEspecialista_PA([FromBody] MedicoEspecialista pMedicoEspecialista)
        {
            if (ModelState.IsValid)
            {
                oMedicoEspecialista.modMedicoEspecialista_PA(pMedicoEspecialista);
                return Ok(pMedicoEspecialista);
            }
            else
            {
                return BadRequest();
            }


        }


        [HttpDelete]
        public IHttpActionResult delMedicoEspecialista_PA([FromBody] MedicoEspecialista pMedicoEspecialista)
        {
            if (ModelState.IsValid)
            {
                oMedicoEspecialista.delMedicoEspecialista_PA(pMedicoEspecialista);
                return Ok(pMedicoEspecialista);
            }
            else
            {
                return BadRequest();
            }


        }

    }
}