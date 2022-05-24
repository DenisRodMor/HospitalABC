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

// NOTA: puede usar el comando "Cambiar nombre" del menú "Refactorizar" para cambiar el nombre de clase "srvMedicamento" en el código, en svc y en el archivo de configuración a la vez.
public class srvMedicamento : IsrvMedicamento
{

    private readonly Logger gobjLogger = LogManager.GetCurrentClassLogger();
    private readonly IMedicamentoLN oMedicamentos = new MedicamentoLN();

    public List<PA_Medicamentos_MostrarDetalle_Result> recMedicamentos_PA()
    {
        List<PA_Medicamentos_MostrarDetalle_Result> lObjRespuesta = new List<PA_Medicamentos_MostrarDetalle_Result>();
        try
        {
            lObjRespuesta = oMedicamentos.recMedicamentos_PA();
        }
        catch (Exception ex)
        {
            gobjLogger.Error("Se produjo un error. Detalle " + ex.Message + " " + ex.InnerException.Message);
            throw ex;
        }
        return lObjRespuesta;
    }

    public PA_Medicamentos_MostrarDetallexid_Result recMedicamentosXID_PA(int id)
    {
        PA_Medicamentos_MostrarDetallexid_Result lObjRespuesta = new PA_Medicamentos_MostrarDetallexid_Result();
        try
        {
            lObjRespuesta = oMedicamentos.recMedicamentosXID_PA(id);
        }
        catch (Exception ex)
        {
            gobjLogger.Error("Se produjo un error. Detalle " + ex.Message + " " + ex.InnerException.Message);
            throw ex;
        }
        return lObjRespuesta;
    }

    public bool insMedicamentos_PA(Medicamento pMedicamentos)
    {
        bool lObjRespuesta = false;
        try
        {
            lObjRespuesta = oMedicamentos.insMedicamentos_PA(pMedicamentos);
        }
        catch (Exception ex)
        {
            gobjLogger.Error("Se produjo un error. Detalle " + ex.Message + " " + ex.InnerException.Message);
            throw ex;
        }
        return lObjRespuesta;
    }

    public bool modMedicamentos_PA(Medicamento pMedicamentos)
    {
        bool lObjRespuesta = false;
        try
        {
            lObjRespuesta = oMedicamentos.modMedicamentos_PA(pMedicamentos);
        }
        catch (Exception ex)
        {
            gobjLogger.Error("Se produjo un error. Detalle " + ex.Message + " " + ex.InnerException.Message);
            throw ex;
        }
        return lObjRespuesta;
    }

    public bool delMedicamentos_PA(Medicamento pMedicamentos)
    {
        bool lObjRespuesta = false;
        try
        {
            lObjRespuesta = oMedicamentos.delMedicamentos_PA(pMedicamentos);
        }
        catch (Exception ex)
        {
            gobjLogger.Error("Se produjo un error. Detalle " + ex.Message + " " + ex.InnerException.Message);
            throw ex;
        }
        return lObjRespuesta;
    }


}
