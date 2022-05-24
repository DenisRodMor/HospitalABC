using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio.Interfaces
{
  public   interface IPacientesLN
    {
       List<PA_Pacientes_MostrarDetalle_Result> recPacientes_PA();

        PA_Pacientes_MostrarDetallexid_Result recPacientesXID_PA(int id);

         bool insPacientes_PA(Paciente pPaciente);

        bool modPacientes_PA(Paciente pPaciente);

        bool delPacientes_PA(Paciente pPaciente);


    }
}
