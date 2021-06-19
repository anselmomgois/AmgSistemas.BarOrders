using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AmgSistemas.BarOrders.Interfaces
{
    public interface IParametroRepository :IGeneric
    {
        List<Models.Parametro> Buscar(string identificadorEmpresa, string identificadorFilial);
    }
}
