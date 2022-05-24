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

// NOTA: puede usar el comando "Cambiar nombre" del menú "Refactorizar" para cambiar el nombre de clase "srvDiagnostico" en el código, en svc y en el archivo de configuración a la vez.
public class srvDiagnostico : IsrvDiagnostico
{

    private readonly Logger gobjLogger = LogManager.GetCurrentClassLogger();
    private readonly IDiagnosticoLN oDiagnostico = new DiagnosticoLN();

    public List<PA_Diagnostico_MostrarDetalle_Result> recDiagnostico_PA()
    {
        List<PA_Diagnostico_MostrarDetalle_Result> lObjRespuesta = new List<PA_Diagnostico_MostrarDetalle_Result>();
        try
        {
            lObjRespuesta = oDiagnostico.recDiagnostico_PA();
        }
        catch (Exception ex)
        {

            gobjLogger.Error("Se produjo un error. Detalle " + ex.Message + " " + ex.InnerException.Message);
            throw ex;
        }
        return lObjRespuesta;
    }

    public PA_Diagnostico_MostrarDetallexid_Result recDiagnosticoXID_PA(int id)
    {
        PA_Diagnostico_MostrarDetallexid_Result lObjRespuesta = new PA_Diagnostico_MostrarDetallexid_Result();
        try
        {
            lObjRespuesta = oDiagnostico.recDiagnosticoXID_PA(id);
        }
        catch (Exception ex)
        {
            gobjLogger.Error("Se produjo un error. Detalle " + ex.Message + " " + ex.InnerException.Message);
            throw ex;
        }
        return lObjRespuesta;
    }

    public bool insDiagnostico_PA(Diagnostico pDiagnostico)
    {
        bool lObjRespuesta = false;
        try
        {
            lObjRespuesta = oDiagnostico.insDiagnostico_PA(pDiagnostico);
        }
        catch (Exception ex)
        {
            gobjLogger.Error("Se produjo un error. Detalle " + ex.Message + " " + ex.InnerException.Message);
            throw ex;
        }
        return lObjRespuesta;
    }

    public bool modDiagnostico_PA(Diagnostico pDiagnostico)
    {
        bool lObjRespuesta = false;
        try
        {
            lObjRespuesta = oDiagnostico.modDiagnostico_PA(pDiagnostico);
        }
        catch (Exception ex)
        {
            gobjLogger.Error("Se produjo un error. Detalle " + ex.Message + " " + ex.InnerException.Message);
            throw ex;
        }
        return lObjRespuesta;
    }

    public bool delDiagnostico_PA(Diagnostico pDiagnostico)
    {
        bool lObjRespuesta = false;
        try
        {
            lObjRespuesta = oDiagnostico.delDiagnostico_PA(pDiagnostico);
        }
        catch (Exception ex)
        {
            gobjLogger.Error("Se produjo un error. Detalle " + ex.Message + " " + ex.InnerException.Message);
            throw ex;
        }
        return lObjRespuesta;
    }



}
