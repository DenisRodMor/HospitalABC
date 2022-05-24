using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

// NOTA: puede usar el comando "Cambiar nombre" del menú "Refactorizar" para cambiar el nombre de interfaz "IsrvRegistroCitas" en el código y en el archivo de configuración a la vez.
[ServiceContract]
public interface IsrvRegistroCitas
{
    [OperationContract]

    List<PA_RegistroCitas_MostrarDetalle_Result> recRegistroCitas_PA();

    [OperationContract]
    PA_RegistroCitas_MostrarDetallexid_Result recRegistroCitasXID_PA(int id);

    [OperationContract]
    bool insRegistroCitas_PA(RegistroCitas pRegistroCitas);

    [OperationContract]
    bool modRegistroCitas_PA(RegistroCitas pRegistroCitas);

    [OperationContract]
    bool delRegistroCitas_PA(RegistroCitas pRegistroCitas);
}
