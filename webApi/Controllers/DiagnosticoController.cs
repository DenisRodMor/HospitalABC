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
    public class DiagnosticoController : ApiController
    {

        private readonly Logger gobjLogger = LogManager.GetCurrentClassLogger();
        private readonly IDiagnosticoLN oDiagnostico = new DiagnosticoLN();

        [HttpGet]
        public List<PA_Diagnostico_MostrarDetalle_Result> recDiagnostico_PA()
        {
            List<PA_Diagnostico_MostrarDetalle_Result> lObjRespuesta = new List<PA_Diagnostico_MostrarDetalle_Result>();
            try
            {
                lObjRespuesta = oDiagnostico.recDiagnostico_PA();
            }
            catch (Exception ex)
            {

                gobjLogger.Error("Se produjo un error. Detalle " + ex.Message + " " + ex.InnerException.Message);
                throw ex;
            }
            return lObjRespuesta;
        }

        [HttpGet]
        public PA_Diagnostico_MostrarDetallexid_Result recDiagnosticoXID_PA(int id)
        {
            PA_Diagnostico_MostrarDetallexid_Result lObjRespuesta = new PA_Diagnostico_MostrarDetallexid_Result();
            try
            {
                lObjRespuesta = oDiagnostico.recDiagnosticoXID_PA(id);
            }
            catch (Exception ex)
            {
                gobjLogger.Error("Se produjo un error. Detalle " + ex.Message + " " + ex.InnerException.Message);
                throw ex;
            }
            return lObjRespuesta;
        }

        [HttpPost]
        public IHttpActionResult insDiagnostico_PA([FromBody] Diagnostico pDiagnostico)
        {
            if (ModelState.IsValid)
            {
                oDiagnostico.insDiagnostico_PA(pDiagnostico);
                return Ok(pDiagnostico);
            }
            else
            {
                return BadRequest();
            }

        }

        [HttpPut]
        public IHttpActionResult modDiagnostico_PA([FromBody] Diagnostico pDiagnostico)
        {
            if (ModelState.IsValid)
            {
                oDiagnostico.modDiagnostico_PA(pDiagnostico);
                return Ok(pDiagnostico);
            }
            else
            {
                return BadRequest();
            }


        }


        [HttpDelete]
        public IHttpActionResult delDiagnostico_PA([FromBody] Diagnostico pDiagnostico)
        {
            if (ModelState.IsValid)
            {
                oDiagnostico.delDiagnostico_PA(pDiagnostico);
                return Ok(pDiagnostico);
            }
            else
            {
                return BadRequest();
            }


        }
    }
}