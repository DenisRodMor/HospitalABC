using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos.Interfaces
{
  public  interface IDiagnosticoAD
    {
        List<PA_Diagnostico_MostrarDetalle_Result> recDiagnostico_PA();

        PA_Diagnostico_MostrarDetallexid_Result recDiagnosticoXID_PA(int id);

        bool insDiagnostico_PA(Diagnostico pDiagnostico);

        bool modDiagnostico_PA(Diagnostico pDiagnostico);

        bool delDiagnostico_PA(Diagnostico pDiagnostico);




    }
}
