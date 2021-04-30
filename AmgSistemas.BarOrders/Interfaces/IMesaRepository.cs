using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AmgSistemas.BarOrders.Interfaces
{
    interface IMesaRepository
    {
        Models.Mesa Buscar(string identificador);
    }
}
