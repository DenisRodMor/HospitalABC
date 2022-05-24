using AccesoDatos.Interfaces;
using Entidades;
using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos.Implementacion
{
   public class MedicamentoAD : IMedicamentoAD
    {

        private readonly Logger gobjLogger = LogManager.GetCurrentClassLogger();
        private HABCEntidades gObjContextoHABC;

        public MedicamentoAD(HABCEntidades lgObjContextoHABC)
        {
            gObjContextoHABC = lgObjContextoHABC;
        }

        public List<PA_Medicamentos_MostrarDetalle_Result> recMedicamentos_PA()
        {
            List<PA_Medicamentos_MostrarDetalle_Result> lObjRespuesta = new List<PA_Medicamentos_MostrarDetalle_Result>();
            try
            {
                lObjRespuesta = gObjContextoHABC.PA_Medicamentos_MostrarDetalle().ToList();
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
                lObjRespuesta = gObjContextoHABC.PA_Medicamentos_MostrarDetallexid(id).FirstOrDefault();
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
            int intValor = 0;

            try
            {
                intValor = gObjContextoHABC.PA_Medicamentos_Insertar(pMedicamentos.IdMedicamento, pMedicamentos.IdCita, pMedicamentos.Cantidad, pMedicamentos.Instrucciones);
                if (intValor == 1)
                {
                    lObjRespuesta = true;
                }
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
            int intValor = 0;

            try
            {
                intValor = gObjContextoHABC.PA_Medicamentos_Actualizar(pMedicamentos.IdMedicamento, pMedicamentos.IdCita, pMedicamentos.Cantidad, pMedicamentos.Instrucciones);
                if (intValor == 1)
                {
                    lObjRespuesta = true;
                }
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
            int intValor = 0;

            try
            {
                intValor = gObjContextoHABC.PA_Medicamentos_Eliminar(pMedicamentos.IdMedicamento);
                if (intValor == 1)
                {
                    lObjRespuesta = true;
                }
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
