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
   public class RegistroCitasAD : IRegistroCitasAD
    {
        private readonly Logger gobjLogger = LogManager.GetCurrentClassLogger();
        private HABCEntidades gObjContextoHABC;

        public RegistroCitasAD(HABCEntidades lgObjContextoHABC)
        {
            gObjContextoHABC = lgObjContextoHABC;
        }

        public List<PA_RegistroCitas_MostrarDetalle_Result> recRegistroCitas_PA()
        {
            List<PA_RegistroCitas_MostrarDetalle_Result> lObjRespuesta = new List<PA_RegistroCitas_MostrarDetalle_Result>();
            try
            {
                lObjRespuesta = gObjContextoHABC.PA_RegistroCitas_MostrarDetalle().ToList();
            }
            catch(Exception ex)
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
                lObjRespuesta = gObjContextoHABC.PA_RegistroCitas_MostrarDetallexid(id).FirstOrDefault();
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
            int intValor = 0;

            try
            {
                intValor = gObjContextoHABC.PA_RegistroCitas_insertar(pRegistroCitas.IdCita, pRegistroCitas.IdPaciente, pRegistroCitas.FechaCita, pRegistroCitas.IdmedicoEspecialista, pRegistroCitas.IdEspecialidad);
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

        public bool modRegistroCitas_PA(RegistroCitas pRegistroCitas)
        {
            bool lObjRespuesta = false;
            int intValor = 0;

            try
            {
                intValor = gObjContextoHABC.PA_RegistroCitas_Actualizar(pRegistroCitas.IdCita, pRegistroCitas.IdPaciente, pRegistroCitas.FechaCita, pRegistroCitas.IdmedicoEspecialista, pRegistroCitas.IdEspecialidad);
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

        public bool delRegistroCitas_PA(RegistroCitas pRegistroCitas)
        {
            bool lObjRespuesta = false;
            int intValor = 0;

            try
            {
                intValor = gObjContextoHABC.PA_RegistroCitas_Eliminar(pRegistroCitas.IdCita);
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
