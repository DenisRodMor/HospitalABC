using Entidades;
using LogicaNegocio.Implementacion;
using LogicaNegocio.Interfaces;
using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

// NOTA: puede usar el comando "Cambiar nombre" del menú "Refactorizar" para cambiar el nombre de clase "srvRegistroCitas" en el código, en svc y en el archivo de configuración a la vez.
public class srvRegistroCitas : IsrvRegistroCitas
{

    private readonly Logger gobjLogger = LogManager.GetCurrentClassLogger();
    private readonly IRegistroCitasLN oRegistroCitas = new RegistroCitasLN();

    public List<PA_RegistroCitas_MostrarDetalle_Result> recRegistroCitas_PA()
    {
        List<PA_RegistroCitas_MostrarDetalle_Result> lObjRespuesta = new List<PA_RegistroCitas_MostrarDetalle_Result>();
        try
        {
            lObjRespuesta = oRegistroCitas.recRegistroCitas_PA();
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
            lObjRespuesta = oRegistroCitas.recRegistroCitasXID_PA(id);
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
            lObjRespuesta = oRegistroCitas.insRegistroCitas_PA(pRegistroCitas);
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
            lObjRespuesta = oRegistroCitas.modRegistroCitas_PA(pRegistroCitas);
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
            lObjRespuesta = oRegistroCitas.delRegistroCitas_PA(pRegistroCitas);
        }
        catch (Exception ex)
        {
            gobjLogger.Error("Se produjo un error. Detalle " + ex.Message + " " + ex.InnerException.Message);
            throw ex;
        }
        return lObjRespuesta;
    }
}
