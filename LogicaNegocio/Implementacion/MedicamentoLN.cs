using AccesoDatos;
using AccesoDatos.Implementacion;
using AccesoDatos.Interfaces;
using Entidades;
using LogicaNegocio.Interfaces;
using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio.Implementacion
{
   public  class MedicamentoLN : IMedicamentoLN
    {

        private readonly Logger gobjLogger = LogManager.GetCurrentClassLogger();
        public static HABCEntidades gObjContextoHABCLN = new HABCEntidades();

        private readonly IMedicamentoAD oMedicamentosAD = new MedicamentoAD(gObjContextoHABCLN);

        public List<PA_Medicamentos_MostrarDetalle_Result> recMedicamentos_PA()
        {
            List<PA_Medicamentos_MostrarDetalle_Result> lObjRespuesta = new List<PA_Medicamentos_MostrarDetalle_Result>();
            try
            {
                lObjRespuesta = oMedicamentosAD.recMedicamentos_PA();
            }
            catch (Exception ex)
            {

                gobjLogger.Error("Se produjo un error. Detalle " + ex.Message + " " + ex.InnerException.Message);
                throw ex;
            }
            return lObjRespuesta;
        }

        public PA_Medicamentos_MostrarDetallexid_Result recMedicamentosXID_PA(int id)
        {
            PA_Medicamentos_MostrarDetallexid_Result lObjRespuesta = new PA_Medicamentos_MostrarDetallexid_Result();
            try
            {
                lObjRespuesta = oMedicamentosAD.recMedicamentosXID_PA(id);
            }
            catch (Exception ex)
            {

                gobjLogger.Error("Se produjo un error. Detalle " + ex.Message + " " + ex.InnerException.Message);
                throw ex;
            }
            return lObjRespuesta;
        }

        public bool insMedicamentos_PA(Medicamento pMedicamentos)
        {
            bool lObjRespuesta = false;
            try
            {
                lObjRespuesta = oMedicamentosAD.insMedicamentos_PA(pMedicamentos);
            }
            catch (Exception ex)
            {

                gobjLogger.Error("Se produjo un error. Detalle " + ex.Message + " " + ex.InnerException.Message);
                throw ex;
            }
            return lObjRespuesta;
        }

        public bool modMedicamentos_PA(Medicamento pMedicamentos)
        {
            bool lObjRespuesta = false;
            try
            {
                lObjRespuesta = oMedicamentosAD.modMedicamentos_PA(pMedicamentos);
            }
            catch (Exception ex)
            {

                gobjLogger.Error("Se produjo un error. Detalle " + ex.Message + " " + ex.InnerException.Message);
                throw ex;
            }
            return lObjRespuesta;
        }

        public bool delMedicamentos_PA(Medicamento pMedicamentos)
        {
            bool lObjRespuesta = false;
            try
            {
                lObjRespuesta = oMedicamentosAD.delMedicamentos_PA(pMedicamentos);
            }
            catch (Exception ex)
            {

                gobjLogger.Error("Se produjo un error. Detalle " + ex.Message + " " + ex.InnerException.Message);
                throw ex;
            }
            return lObjRespuesta;
        }

    }
}
