using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos.Interfaces
{
   public interface IEspecialidadAD
    {
        List<PA_Especialidad_MostrarDetalle_Result> recEspecialidad_PA();

        PA_Especialidad_MostrarDetallexid_Result recEspecialidadXID_PA(int id);

        bool insEspecialidad_PA(Especialidades pEspecialidad);

        bool modEspecialidad_PA(Especialidades pEspecialidad);

        bool delEspecialidad_PA(Especialidades pEspecialidad);

    }
}
