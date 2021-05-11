using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AmgSistemas.BarOrders.Classes;

namespace AmgSistemas.BarOrders.Enumeradores
{
    public enum EstadoMesa
    {
        [ValorEnum("OC")]
        Ocupado,
        [ValorEnum("LV")]
        Livre,
        [ValorEnum("FE")]
        Fechamento
    }
}
