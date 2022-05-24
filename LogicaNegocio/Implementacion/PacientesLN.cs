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
   public class PacientesLN : IPacientesLN
    {

        private readonly Logger gobjLogger = LogManager.GetCurrentClassLogger();
        public static HABCEntidades gObjContextoHABCLN = new HABCEntidades();

        private readonly IPacientesAD opacientesAD = new PacientesAD(gObjContextoHABCLN);


        public List<PA_Pacientes_MostrarDetalle_Result> recPacientes_PA()
        {
            List<PA_Pacientes_MostrarDetalle_Result> lObjRespuesta = new List<PA_Pacientes_MostrarDetalle_Result>();
            try
            {
                lObjRespuesta = opacientesAD.recPacientes_PA();
            }
            catch (Exception ex)
            {

                gobjLogger.Error("Se produjo un error. Detalle " + ex.Message + " " + ex.InnerException.Message);
                throw ex;
            }
            return lObjRespuesta;
        }


        public PA_Pacientes_MostrarDetallexid_Result recPacientesXID_PA(int id)
        {
            PA_Pacientes_MostrarDetallexid_Result lObjRespuesta = new PA_Pacientes_MostrarDetallexid_Result();
            try
            {
                lObjRespuesta = opacientesAD.recPacientesXID_PA(id);
            }
            catch (Exception ex)
            {

                gobjLogger.Error("Se produjo un error. Detalle " + ex.Message + " " + ex.InnerException.Message);
                throw ex;
            }
            return lObjRespuesta;
        }

        public bool insPacientes_PA(Paciente pPaciente)
        {
            bool lObjRespuesta = false;
            try
            {
                lObjRespuesta = opacientesAD.insPacientes_PA(pPaciente);
            }
            catch (Exception ex)
            {

                gobjLogger.Error("Se produjo un error. Detalle " + ex.Message + " " + ex.InnerException.Message);
                throw ex;
            }
            return lObjRespuesta;
        }

        public bool modPacientes_PA(Paciente pPaciente)
        {
            bool lObjRespuesta = false;
            try
            {
                lObjRespuesta = opacientesAD.modPacientes_PA(pPaciente);
            }
            catch (Exception ex)
            {

                gobjLogger.Error("Se produjo un error. Detalle " + ex.Message + " " + ex.InnerException.Message);
                throw ex;
            }
            return lObjRespuesta;
        }

        public bool delPacientes_PA(Paciente pPaciente)
        {
            bool lObjRespuesta = false;
            try
            {
                lObjRespuesta = opacientesAD.delPacientes_PA(pPaciente);
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
