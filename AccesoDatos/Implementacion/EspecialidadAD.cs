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
   public class EspecialidadAD : IEspecialidadAD
    {

        private readonly Logger gobjLogger = LogManager.GetCurrentClassLogger();
        private HABCEntidades gObjContextoHABC;

        public EspecialidadAD(HABCEntidades lgObjContextoHABC)
        {
            gObjContextoHABC = lgObjContextoHABC;
        }

        public List<PA_Especialidad_MostrarDetalle_Result> recEspecialidad_PA()
        {
            List<PA_Especialidad_MostrarDetalle_Result> lObjRespuesta = new List<PA_Especialidad_MostrarDetalle_Result>();
            try
            {
                lObjRespuesta = gObjContextoHABC.PA_Especialidad_MostrarDetalle().ToList();
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
                lObjRespuesta = gObjContextoHABC.PA_Especialidad_MostrarDetallexid(id).FirstOrDefault();
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
            int intValor = 0;

            try
            {
                intValor = gObjContextoHABC.PA_Especialidad_insertar(pEspecialidad.IdEspecialidades, pEspecialidad.TipoEspecialidad);
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

        public bool modEspecialidad_PA(Especialidades pEspecialidad)
        {
            bool lObjRespuesta = false;
            int intValor = 0;

            try
            {
                intValor = gObjContextoHABC.PA_Especialidad_Actualizar(pEspecialidad.IdEspecialidades, pEspecialidad.TipoEspecialidad);
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

        public bool delEspecialidad_PA(Especialidades pEspecialidad)
        {
            bool lObjRespuesta = false;
            int intValor = 0;

            try
            {
                intValor = gObjContextoHABC.PA_Especialidad_Eliminar(pEspecialidad.IdEspecialidades);
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
