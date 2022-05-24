using Entidades;
using System.Collections.Generic;
using System.ServiceModel;

// NOTA: puede usar el comando "Cambiar nombre" del menú "Refactorizar" para cambiar el nombre de interfaz "IsrvPacientes" en el código y en el archivo de configuración a la vez.
[ServiceContract]
public interface IsrvPacientes
{
    [OperationContract]
    List<PA_Pacientes_MostrarDetalle_Result> recPacientes_PA();

    [OperationContract]
    PA_Pacientes_MostrarDetallexid_Result recPacientesXID_PA(int id);

    [OperationContract]
    bool insPacientes_PA(Paciente pPaciente);

    [OperationContract]
    bool modPacientes_PA(Paciente pPaciente);

    [OperationContract]
    bool delPacientes_PA(Paciente pPaciente);
}
