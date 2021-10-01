using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AmgSistemas.BarOrders.Interfaces
{
    public interface IMesaServices:IGeneric
    {
        Models.Mesa Buscar(string identificador, string senha, string codigoDispositivo);
    }
}
