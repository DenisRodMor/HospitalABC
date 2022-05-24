using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

// NOTA: puede usar el comando "Cambiar nombre" del menú "Refactorizar" para cambiar el nombre de interfaz "IsrvMedicamento" en el código y en el archivo de configuración a la vez.
[ServiceContract]
public interface IsrvMedicamento
{
    [OperationContract]

    List<PA_Medicamentos_MostrarDetalle_Result> recMedicamentos_PA();

    [OperationContract]
    PA_Medicamentos_MostrarDetallexid_Result recMedicamentosXID_PA(int id);

    [OperationContract]
    bool insMedicamentos_PA(Medicamento pMedicamentos);

    [OperationContract]
    bool modMedicamentos_PA(Medicamento pMedicamentos);

    [OperationContract]
    bool delMedicamentos_PA(Medicamento pMedicamentos);


}
