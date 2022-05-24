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
   public  class MedicoEspecialistaLN : IMedicoEspecialistaLN
    {

        private readonly Logger gobjLogger = LogManager.GetCurrentClassLogger();
        public static HABCEntidades gObjContextoHABCLN = new HABCEntidades();

        private readonly IMedicoEspecialistaAD oMedicoEspecialistaAD = new MedicoEspecialistaAD(gObjContextoHABCLN);

        public List<PA_MedicoEspecialista_MostrarDetalle_Result> recMedicoEspecialista_PA()
        {
            List<PA_MedicoEspecialista_MostrarDetalle_Result> lObjRespuesta = new List<PA_MedicoEspecialista_MostrarDetalle_Result>();
            try
            {
                lObjRespuesta = oMedicoEspecialistaAD.recMedicoEspecialista_PA();
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
                lObjRespuesta = oMedicoEspecialistaAD.recMedicoEspecialistaXID_PA(id);
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
            try
            {
                lObjRespuesta = oMedicoEspecialistaAD.insMedicoEspecialista_PA(pMedicoEspecialista);
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
            try
            {
                lObjRespuesta = oMedicoEspecialistaAD.modMedicoEspecialista_PA(pMedicoEspecialista);
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
            try
            {
                lObjRespuesta = oMedicoEspecialistaAD.delMedicoEspecialista_PA(pMedicoEspecialista);
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
