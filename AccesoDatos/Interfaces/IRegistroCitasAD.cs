using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos.Interfaces
{
   public interface IRegistroCitasAD
    {

        List<PA_RegistroCitas_MostrarDetalle_Result> recRegistroCitas_PA();
        PA_RegistroCitas_MostrarDetallexid_Result recRegistroCitasXID_PA(int id);
        bool insRegistroCitas_PA(RegistroCitas pRegistroCitas);
        bool modRegistroCitas_PA(RegistroCitas pRegistroCitas);
        bool delRegistroCitas_PA(RegistroCitas pRegistroCitas);
    }
}
