using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AmgSistemas.BarOrders.Interfaces
{
    public interface IEmpresaRepository:IGeneric
    {
        Models.Empresa Buscar(string identificador);
    }
}
