using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

// NOTA: puede usar el comando "Cambiar nombre" del menú "Refactorizar" para cambiar el nombre de interfaz "IsrvEspecialidad" en el código y en el archivo de configuración a la vez.
[ServiceContract]
public interface IsrvEspecialidad
{
    [OperationContract]
    List<PA_Especialidad_MostrarDetalle_Result> recEspecialidad_PA();

    [OperationContract]
    PA_Especialidad_MostrarDetallexid_Result recEspecialidadXID_PA(int id);

    [OperationContract]
    bool insEspecialidad_PA(Especialidades pEspecialidad);

    [OperationContract]
    bool modEspecialidad_PA(Especialidades pEspecialidad);

    [OperationContract]
    bool delEspecialidad_PA(Especialidades pEspecialidad);
}
