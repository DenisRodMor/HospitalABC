using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos.Interfaces
{
   public interface IMedicoEspecialistaAD
    {
        List<PA_MedicoEspecialista_MostrarDetalle_Result> recMedicoEspecialista_PA();

        PA_MedicoEspecialista_MostrarDetallexid_Result recMedicoEspecialistaXID_PA(int id);

        bool insMedicoEspecialista_PA(MedicoEspecialista pMedicoEspecialista);

        bool modMedicoEspecialista_PA(MedicoEspecialista pMedicoEspecialista);

        bool delMedicoEspecialista_PA(MedicoEspecialista pMedicoEspecialista);

    }
}
