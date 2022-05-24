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
    public class MedicamentoController : ApiController
    {
        private readonly Logger gobjLogger = LogManager.GetCurrentClassLogger();
        private readonly IMedicamentoLN oMedicamentos = new MedicamentoLN();

        [HttpGet]
        public List<PA_Medicamentos_MostrarDetalle_Result> recMedicamentos_PA()
        {
            List<PA_Medicamentos_MostrarDetalle_Result> lObjRespuesta = new List<PA_Medicamentos_MostrarDetalle_Result>();
            try
            {
                lObjRespuesta = oMedicamentos.recMedicamentos_PA();
            }
            catch (Exception ex)
            {
                gobjLogger.Error("Se produjo un error. Detalle " + ex.Message + " " + ex.InnerException.Message);
                throw ex;
            }
            return lObjRespuesta;
        }

        [HttpGet]
        public PA_Medicamentos_MostrarDetallexid_Result recMedicamentosXID_PA(int id)
        {
            PA_Medicamentos_MostrarDetallexid_Result lObjRespuesta = new PA_Medicamentos_MostrarDetallexid_Result();
            try
            {
                lObjRespuesta = oMedicamentos.recMedicamentosXID_PA(id);
            }
            catch (Exception ex)
            {
                gobjLogger.Error("Se produjo un error. Detalle " + ex.Message + " " + ex.InnerException.Message);
                throw ex;
            }
            return lObjRespuesta;
        }


        [HttpPost]
        public IHttpActionResult insMedicamentos_PA([FromBody] Medicamento pMedicamentos)
        {
            if (ModelState.IsValid)
            {
                oMedicamentos.insMedicamentos_PA(pMedicamentos);
                return Ok(pMedicamentos);
            }
            else
            {
                return BadRequest();
            }

           
        }

        [HttpPut]
        public IHttpActionResult modMedicamentos_PA([FromBody] Medicamento pMedicamentos)
        {
            if (ModelState.IsValid)
            {
                oMedicamentos.modMedicamentos_PA(pMedicamentos);
                return Ok(pMedicamentos);
            }
            else
            {
                return BadRequest();
            }


        }


        [HttpDelete]
        public IHttpActionResult delMedicamentos_PA([FromBody] Medicamento pMedicamentos)
        {
            if (ModelState.IsValid)
            {
                oMedicamentos.delMedicamentos_PA(pMedicamentos);
                return Ok(pMedicamentos);
            }
            else
            {
                return BadRequest();
            }


        }
    }
}