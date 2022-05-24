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
   public class MedicoEspecialistaAD : IMedicoEspecialistaAD
    {
        private readonly Logger gobjLogger = LogManager.GetCurrentClassLogger();
        private HABCEntidades gObjContextoHABC;

        public MedicoEspecialistaAD(HABCEntidades lgObjContextoHABC)
        {
            gObjContextoHABC = lgObjContextoHABC;
        }

        public List<PA_MedicoEspecialista_MostrarDetalle_Result> recMedicoEspecialista_PA()
        {
            List<PA_MedicoEspecialista_MostrarDetalle_Result> lObjRespuesta = new List<PA_MedicoEspecialista_MostrarDetalle_Result>();
            try
            {
                lObjRespuesta = gObjContextoHABC.PA_MedicoEspecialista_MostrarDetalle().ToList();
            }
            catch (Exception ex)
            {

                gobjLogger.Error("Se produjo un error. Detalle " + ex.Message + " " + ex.InnerException.Message);
                throw ex;
            }
            return lObjRespuesta;
        }


        public PA_MedicoEspecialista_MostrarDetallexid_Result recMedicoEspecialistaXID_PA(int id)
        {
            PA_MedicoEspecialista_MostrarDetallexid_Result lObjRespuesta = new PA_MedicoEspecialista_MostrarDetallexid_Result();
            try
            {
                lObjRespuesta = gObjContextoHABC.PA_MedicoEspecialista_MostrarDetallexid(id).FirstOrDefault();
            }
            catch (Exception ex)
            {

                gobjLogger.Error("Se produjo un error. Detalle " + ex.Message + " " + ex.InnerException.Message);
                throw ex;
            }
            return lObjRespuesta;
        }

        public bool insMedicoEspecialista_PA(MedicoEspecialista pMedicoEspecialista)
        {
            bool lObjRespuesta = false;
            int intValor = 0;

            try
            {
                intValor = gObjContextoHABC.PA_MedicoEspecialista_insertar(pMedicoEspecialista.IdmedicoEspecialista, pMedicoEspecialista.IdEspecialidad, pMedicoEspecialista.Nombre);
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

        public bool modMedicoEspecialista_PA(MedicoEspecialista pMedicoEspecialista)
        {
            bool lObjRespuesta = false;
            int intValor = 0;

            try
            {
                intValor = gObjContextoHABC.PA_MedicoEspecialista_Actualizar(pMedicoEspecialista.IdmedicoEspecialista, pMedicoEspecialista.IdEspecialidad, pMedicoEspecialista.Nombre);
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

        public bool delMedicoEspecialista_PA(MedicoEspecialista pMedicoEspecialista)
        {
            bool lObjRespuesta = false;
            int intValor = 0;

            try
            {
                intValor = gObjContextoHABC.PA_MedicoEspecialista_Eliminar(pMedicoEspecialista.IdmedicoEspecialista);
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
