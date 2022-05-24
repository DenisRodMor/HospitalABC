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
   public class EspecialidadLN : IEspecialidadLN
    {

        private readonly Logger gobjLogger = LogManager.GetCurrentClassLogger();
        public static HABCEntidades gObjContextoHABCLN = new HABCEntidades();

        private readonly IEspecialidadAD oEspecialidadAD = new EspecialidadAD(gObjContextoHABCLN);

        public List<PA_Especialidad_MostrarDetalle_Result> recEspecialidad_PA()
        {
            List<PA_Especialidad_MostrarDetalle_Result> lObjRespuesta = new List<PA_Especialidad_MostrarDetalle_Result>();
            try
            {
                lObjRespuesta = oEspecialidadAD.recEspecialidad_PA();
            }
            catch (Exception ex)
            {

                gobjLogger.Error("Se produjo un error. Detalle " + ex.Message + " " + ex.InnerException.Message);
                throw ex;
            }
            return lObjRespuesta;
        }

        public PA_Especialidad_MostrarDetallexid_Result recEspecialidadXID_PA(int id)
        {
            PA_Especialidad_MostrarDetallexid_Result lObjRespuesta = new PA_Especialidad_MostrarDetallexid_Result();
            try
            {
                lObjRespuesta = oEspecialidadAD.recEspecialidadXID_PA(id);
            }
            catch (Exception ex)
            {

                gobjLogger.Error("Se produjo un error. Detalle " + ex.Message + " " + ex.InnerException.Message);
                throw ex;
            }
            return lObjRespuesta;
        }

        public bool insEspecialidad_PA(Especialidades pEspecialidad)
        {
            bool lObjRespuesta = false;
            try
            {
                lObjRespuesta = oEspecialidadAD.insEspecialidad_PA(pEspecialidad);
            }
            catch (Exception ex)
            {

                gobjLogger.Error("Se produjo un error. Detalle " + ex.Message + " " + ex.InnerException.Message);
                throw ex;
            }
            return lObjRespuesta;
        }

        public bool modEspecialidad_PA(Especialidades pEspecialidad)
        {
            bool lObjRespuesta = false;
            try
            {
                lObjRespuesta = oEspecialidadAD.modEspecialidad_PA(pEspecialidad);
            }
            catch (Exception ex)
            {

                gobjLogger.Error("Se produjo un error. Detalle " + ex.Message + " " + ex.InnerException.Message);
                throw ex;
            }
            return lObjRespuesta;
        }

        public bool delEspecialidad_PA(Especialidades pEspecialidad)
        {
            bool lObjRespuesta = false;
            try
            {
                lObjRespuesta = oEspecialidadAD.delEspecialidad_PA(pEspecialidad);
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
