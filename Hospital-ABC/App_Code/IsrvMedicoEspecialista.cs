using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

// NOTA: puede usar el comando "Cambiar nombre" del menú "Refactorizar" para cambiar el nombre de interfaz "IsrvMedicoEspecialista" en el código y en el archivo de configuración a la vez.
[ServiceContract]
public interface IsrvMedicoEspecialista
{
    [OperationContract]
    List<PA_MedicoEspecialista_MostrarDetalle_Result> recMedicoEspecialista_PA();

    [OperationContract]
    PA_MedicoEspecialista_MostrarDetallexid_Result recMedicoEspecialistaXID_PA(int id);

    [OperationContract]
    bool insMedicoEspecialista_PA(MedicoEspecialista pMedicoEspecialista);

    [OperationContract]
    bool modMedicoEspecialista_PA(MedicoEspecialista pMedicoEspecialista);

    [OperationContract]
    bool delMedicoEspecialista_PA(MedicoEspecialista pMedicoEspecialista);


}
