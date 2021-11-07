using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AmgSistemas.BarOrders.Classes;

namespace AmgSistemas.BarOrders.Enumeradores
{
    public enum CodigosParametros
    {
        [ValorEnum("TrabalhaPorMesa")]
        TrabalhaPorMesa,
        [ValorEnum("TrabalhaPorComanda")]
        TrabalhaPorComanda,
        [ValorEnum("MultiplasComandaPorMesa")]
        MultiplasComandaPorMesa,
        [ValorEnum("CodigoPrefixoComanda")]
        CodigoPrefixoComanda
    }
}
