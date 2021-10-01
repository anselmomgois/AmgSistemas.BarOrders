using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AmgSistemas.BarOrders.Interfaces
{
    public interface IParametroServices :IGeneric
    {
        List<Models.Parametro> BuscarParametros(string identificadorEmpresa, string identificadorFilial);

        Models.Parametro BuscarParametro(string identificadorEmpresa, string identificadorFilial, string codigoParametro);
    }
}
