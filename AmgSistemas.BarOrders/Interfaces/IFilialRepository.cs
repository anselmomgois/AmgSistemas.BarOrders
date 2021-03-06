using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AmgSistemas.BarOrders.Interfaces
{
    public interface IFilialRepository:IGeneric
    {
        Models.Filial Buscar(string identificador);

    }
}
