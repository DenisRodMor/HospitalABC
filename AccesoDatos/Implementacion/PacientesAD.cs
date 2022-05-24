using AccesoDatos.Interfaces;
using Entidades;
using NLog;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AccesoDatos.Implementacion
{
    public class PacientesAD : IPacientesAD
    {
        private readonly Logger gobjLogger = LogManager.GetCurrentClassLogger();
        private HABCEntidades gObjContextoHABC;

        public PacientesAD(HABCEntidades lgObjContextoHABC)
        {
            gObjContextoHABC = lgObjContextoHABC;
        }

        public List<PA_Pacientes_MostrarDetalle_Result> recPacientes_PA()
        {
            List<PA_Pacientes_MostrarDetalle_Result> lObjRespuesta = new List<PA_Pacientes_MostrarDetalle_Result>();
            try
            {
                lObjRespuesta = gObjContextoHABC.PA_Pacientes_MostrarDetalle().ToList();
            }
            catch(Exception ex)
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
                lObjRespuesta = gObjContextoHABC.PA_Pacientes_MostrarDetallexid(id).FirstOrDefault();
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
            int intValor = 0;

            try
            {
                intValor = gObjContextoHABC.PA_Pacientes_insertar(pPaciente.IdPaciente, pPaciente.Nombre, pPaciente.PrimerApellido, pPaciente.SegundoApellido, pPaciente.Telefono, pPaciente.Direccion, pPaciente.Correo, pPaciente.Sexo, pPaciente.FechaNacimiento, pPaciente.FechaAdmision);
                if(intValor == 1)
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

        public bool modPacientes_PA(Paciente pPaciente)
        {
            bool lObjRespuesta = false;
            int intValor = 0;

            try
            {
                intValor = gObjContextoHABC.PA_Pacientes_Actualizar(pPaciente.IdPaciente, pPaciente.Nombre, pPaciente.PrimerApellido, pPaciente.SegundoApellido, pPaciente.Telefono, pPaciente.Direccion, pPaciente.Correo, pPaciente.Sexo, pPaciente.FechaNacimiento, pPaciente.FechaAdmision);
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

        public bool delPacientes_PA(Paciente pPaciente)
        {
            bool lObjRespuesta = false;
            int intValor = 0;

            try
            {
                intValor = gObjContextoHABC.PA_Pacientes_Eliminar(pPaciente.IdPaciente);
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
