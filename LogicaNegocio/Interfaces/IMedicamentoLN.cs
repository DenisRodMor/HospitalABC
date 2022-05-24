using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio.Interfaces
{
   public interface IMedicamentoLN
    {
        List<PA_Medicamentos_MostrarDetalle_Result> recMedicamentos_PA();

        PA_Medicamentos_MostrarDetallexid_Result recMedicamentosXID_PA(int id);

        bool insMedicamentos_PA(Medicamento pMedicamentos);

        bool modMedicamentos_PA(Medicamento pMedicamentos);

        bool delMedicamentos_PA(Medicamento pMedicamentos);

    }
}
