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
   public class DiagnosticoAD : IDiagnosticoAD
    {

        private readonly Logger gobjLogger = LogManager.GetCurrentClassLogger();
        private HABCEntidades gObjContextoHABC;

        public DiagnosticoAD(HABCEntidades lgObjContextoHABC)
        {
            gObjContextoHABC = lgObjContextoHABC;
        }

        public List<PA_Diagnostico_MostrarDetalle_Result> recDiagnostico_PA()
        {
            List<PA_Diagnostico_MostrarDetalle_Result> lObjRespuesta = new List<PA_Diagnostico_MostrarDetalle_Result>();
            try
            {
                lObjRespuesta = gObjContextoHABC.PA_Diagnostico_MostrarDetalle().ToList();
            }
            catch (Exception ex)
            {

                gobjLogger.Error("Se produjo un error. Detalle " + ex.Message + " " + ex.InnerException.Message);
                throw ex;
            }
            return lObjRespuesta;
        }

        public PA_Diagnostico_MostrarDetallexid_Result recDiagnosticoXID_PA(int id)
        {
            PA_Diagnostico_MostrarDetallexid_Result lObjRespuesta = new PA_Diagnostico_MostrarDetallexid_Result();
            try
            {
                lObjRespuesta = gObjContextoHABC.PA_Diagnostico_MostrarDetallexid(id).FirstOrDefault();
            }
            catch (Exception ex)
            {

                gobjLogger.Error("Se produjo un error. Detalle " + ex.Message + " " + ex.InnerException.Message);
                throw ex;
            }
            return lObjRespuesta;
        }

        public bool insDiagnostico_PA(Diagnostico pDiagnostico)
        {
            bool lObjRespuesta = false;
            int intValor = 0;

            try
            {
                intValor = gObjContextoHABC.PA_Diagnostico_insertar(pDiagnostico.IdDiagnostico, pDiagnostico.IdCita, pDiagnostico.Observaciones);
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

        public bool modDiagnostico_PA(Diagnostico pDiagnostico)
        {
            bool lObjRespuesta = false;
            int intValor = 0;

            try
            {
                intValor = gObjContextoHABC.PA_Diagnostico_insertar(pDiagnostico.IdDiagnostico, pDiagnostico.IdCita, pDiagnostico.Observaciones);
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

        public bool delDiagnostico_PA(Diagnostico pDiagnostico)
        {
            bool lObjRespuesta = false;
            int intValor = 0;

            try
            {
                intValor = gObjContextoHABC.PA_Diagnostico_Eliminar(pDiagnostico.IdDiagnostico);
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
