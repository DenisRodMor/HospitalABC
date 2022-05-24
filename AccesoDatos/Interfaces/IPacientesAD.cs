using Entidades;
using System.Collections.Generic;

namespace AccesoDatos.Interfaces
{
    public interface IPacientesAD
    {
        List<PA_Pacientes_MostrarDetalle_Result> recPacientes_PA();
        PA_Pacientes_MostrarDetallexid_Result recPacientesXID_PA(int id);
        bool insPacientes_PA(Paciente pPaciente);
        bool modPacientes_PA(Paciente pPaciente);
        bool delPacientes_PA(Paciente pPaciente);
    }
}
