using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AmgSistemas.BarOrders.Classes;

namespace AmgSistemas.BarOrders.Enumeradores
{
    public enum EstadoComanda
    {
        [ValorEnum("AB")]
        Aberta,
        [ValorEnum("FE")]
        Fechada,
        [ValorEnum("CA")]
        Cancelada
    }
}
