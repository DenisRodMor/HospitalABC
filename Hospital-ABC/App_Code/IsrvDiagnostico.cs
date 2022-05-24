using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

// NOTA: puede usar el comando "Cambiar nombre" del menú "Refactorizar" para cambiar el nombre de interfaz "IsrvDiagnostico" en el código y en el archivo de configuración a la vez.
[ServiceContract]
public interface IsrvDiagnostico
{
    [OperationContract] 
    List<PA_Diagnostico_MostrarDetalle_Result> recDiagnostico_PA();

    [OperationContract]
    PA_Diagnostico_MostrarDetallexid_Result recDiagnosticoXID_PA(int id);

    [OperationContract]
    bool insDiagnostico_PA(Diagnostico pDiagnostico);

    [OperationContract]
    bool modDiagnostico_PA(Diagnostico pDiagnostico);

    [OperationContract]
    bool delDiagnostico_PA(Diagnostico pDiagnostico);
}
