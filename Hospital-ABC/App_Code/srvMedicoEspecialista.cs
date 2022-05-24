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

// NOTA: puede usar el comando "Cambiar nombre" del menú "Refactorizar" para cambiar el nombre de clase "srvMedicoEspecialista" en el código, en svc y en el archivo de configuración a la vez.
public class srvMedicoEspecialista : IsrvMedicoEspecialista
{

    private readonly Logger gobjLogger = LogManager.GetCurrentClassLogger();
    private readonly IMedicoEspecialistaLN oMedicoEspecialista = new MedicoEspecialistaLN();


    public List<PA_MedicoEspecialista_MostrarDetalle_Result> recMedicoEspecialista_PA()
    {
        List<PA_MedicoEspecialista_MostrarDetalle_Result> lObjRespuesta = new List<PA_MedicoEspecialista_MostrarDetalle_Result>();
        try
        {
            lObjRespuesta = oMedicoEspecialista.recMedicoEspecialista_PA();
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
            lObjRespuesta = oMedicoEspecialista.recMedicoEspecialistaXID_PA(id);
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
            lObjRespuesta = oMedicoEspecialista.insMedicoEspecialista_PA(pMedicoEspecialista);
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
            lObjRespuesta = oMedicoEspecialista.modMedicoEspecialista_PA(pMedicoEspecialista);
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
            lObjRespuesta = oMedicoEspecialista.delMedicoEspecialista_PA(pMedicoEspecialista);
        }
        catch (Exception ex)
        {
            gobjLogger.Error("Se produjo un error. Detalle " + ex.Message + " " + ex.InnerException.Message);
            throw ex;
        }
        return lObjRespuesta;
    }

}
