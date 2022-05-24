using Entidades;
using LogicaNegocio.Implementacion;
using LogicaNegocio.Interfaces;
using NLog;
using System;
using System.Collections.Generic;

// NOTA: puede usar el comando "Cambiar nombre" del menú "Refactorizar" para cambiar el nombre de clase "srvPacientes" en el código, en svc y en el archivo de configuración a la vez.
public class srvPacientes : IsrvPacientes
{

    private readonly Logger gobjLogger = LogManager.GetCurrentClassLogger();
    private readonly IPacientesLN opacientes = new PacientesLN();

    public List<PA_Pacientes_MostrarDetalle_Result> recPacientes_PA()
    {
        List<PA_Pacientes_MostrarDetalle_Result> lObjRespuesta = new List<PA_Pacientes_MostrarDetalle_Result>();
        try
        {
            lObjRespuesta = opacientes.recPacientes_PA();
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
            lObjRespuesta = opacientes.recPacientesXID_PA(id);
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
            lObjRespuesta = opacientes.insPacientes_PA(pPaciente);
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
            lObjRespuesta = opacientes.modPacientes_PA(pPaciente);
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
            lObjRespuesta = opacientes.delPacientes_PA(pPaciente);
        }
        catch (Exception ex)
        {
            gobjLogger.Error("Se produjo un error. Detalle " + ex.Message + " " + ex.InnerException.Message);
            throw ex;
        }
        return lObjRespuesta;
    }

}
