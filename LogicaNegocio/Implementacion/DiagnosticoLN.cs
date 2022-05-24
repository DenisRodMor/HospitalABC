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
   public class DiagnosticoLN : IDiagnosticoLN
    {

        private readonly Logger gobjLogger = LogManager.GetCurrentClassLogger();
        public static HABCEntidades gObjContextoHABCLN = new HABCEntidades();

        private readonly IDiagnosticoAD oDiagnosticoAD = new DiagnosticoAD(gObjContextoHABCLN);

        public List<PA_Diagnostico_MostrarDetalle_Result> recDiagnostico_PA()
        {
            List<PA_Diagnostico_MostrarDetalle_Result> lObjRespuesta = new List<PA_Diagnostico_MostrarDetalle_Result>();
            try
            {
                lObjRespuesta = oDiagnosticoAD.recDiagnostico_PA();
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
                lObjRespuesta = oDiagnosticoAD.recDiagnosticoXID_PA(id);
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
            try
            {
                lObjRespuesta = oDiagnosticoAD.insDiagnostico_PA(pDiagnostico);
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
            try
            {
                lObjRespuesta = oDiagnosticoAD.modDiagnostico_PA(pDiagnostico);
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
            try
            {
                lObjRespuesta = oDiagnosticoAD.delDiagnostico_PA(pDiagnostico);
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
