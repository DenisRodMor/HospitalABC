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
    public class RegistroCitasLN : IRegistroCitasLN
    {

        private readonly Logger gobjLogger = LogManager.GetCurrentClassLogger();
        public static HABCEntidades gObjContextoHABCLN = new HABCEntidades();

        private readonly IRegistroCitasAD oRegistroCitasAD = new RegistroCitasAD(gObjContextoHABCLN);

        public List<PA_RegistroCitas_MostrarDetalle_Result> recRegistroCitas_PA()
        {
            List<PA_RegistroCitas_MostrarDetalle_Result> lObjRespuesta = new List<PA_RegistroCitas_MostrarDetalle_Result>();
            try
            {
                lObjRespuesta = oRegistroCitasAD.recRegistroCitas_PA();
            }
            catch (Exception ex)
            {

                gobjLogger.Error("Se produjo un error. Detalle " + ex.Message + " " + ex.InnerException.Message);
                throw ex;
            }
            return lObjRespuesta;
        }

        public PA_RegistroCitas_MostrarDetallexid_Result recRegistroCitasXID_PA(int id)
        {
            PA_RegistroCitas_MostrarDetallexid_Result lObjRespuesta = new PA_RegistroCitas_MostrarDetallexid_Result();
            try
            {
                lObjRespuesta = oRegistroCitasAD.recRegistroCitasXID_PA(id);
            }
            catch (Exception ex)
            {

                gobjLogger.Error("Se produjo un error. Detalle " + ex.Message + " " + ex.InnerException.Message);
                throw ex;
            }
            return lObjRespuesta;
        }

        public bool insRegistroCitas_PA(RegistroCitas pRegistroCitas)
        {
            bool lObjRespuesta = false;
            try
            {
                lObjRespuesta = oRegistroCitasAD.insRegistroCitas_PA(pRegistroCitas);
            }
            catch (Exception ex)
            {

                gobjLogger.Error("Se produjo un error. Detalle " + ex.Message + " " + ex.InnerException.Message);
                throw ex;
            }
            return lObjRespuesta;
        }

        public bool modRegistroCitas_PA(RegistroCitas pRegistroCitas)
        {
            bool lObjRespuesta = false;
            try
            {
                lObjRespuesta = oRegistroCitasAD.modRegistroCitas_PA(pRegistroCitas);
            }
            catch (Exception ex)
            {

                gobjLogger.Error("Se produjo un error. Detalle " + ex.Message + " " + ex.InnerException.Message);
                throw ex;
            }
            return lObjRespuesta;
        }

        public bool delRegistroCitas_PA(RegistroCitas pRegistroCitas)
        {
            bool lObjRespuesta = false;
            try
            {
                lObjRespuesta = oRegistroCitasAD.delRegistroCitas_PA(pRegistroCitas);
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
