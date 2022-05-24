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

// NOTA: puede usar el comando "Cambiar nombre" del menú "Refactorizar" para cambiar el nombre de clase "srvEspecialidad" en el código, en svc y en el archivo de configuración a la vez.
public class srvEspecialidad : IsrvEspecialidad
{


    private readonly Logger gobjLogger = LogManager.GetCurrentClassLogger();
    private readonly IEspecialidadLN oEspecialidad = new EspecialidadLN();

    public List<PA_Especialidad_MostrarDetalle_Result> recEspecialidad_PA()
    {
        List<PA_Especialidad_MostrarDetalle_Result> lObjRespuesta = new List<PA_Especialidad_MostrarDetalle_Result>();
        try
        {
            lObjRespuesta = oEspecialidad.recEspecialidad_PA();
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
            lObjRespuesta = oEspecialidad.recEspecialidadXID_PA(id);
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
            lObjRespuesta = oEspecialidad.insEspecialidad_PA(pEspecialidad);
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
            lObjRespuesta = oEspecialidad.modEspecialidad_PA(pEspecialidad);
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
            lObjRespuesta = oEspecialidad.delEspecialidad_PA(pEspecialidad);
        }
        catch (Exception ex)
        {
            gobjLogger.Error("Se produjo un error. Detalle " + ex.Message + " " + ex.InnerException.Message);
            throw ex;
        }
        return lObjRespuesta;
    }


}
