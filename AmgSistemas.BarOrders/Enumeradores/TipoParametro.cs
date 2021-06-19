using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AmgSistemas.BarOrders.Classes;

namespace AmgSistemas.BarOrders.Enumeradores
{
    public enum TipoParametro
    {
        [ValorEnum("AN")]
        AlfaNumerico,
        [ValorEnum("NU")]
        Numerico,
        [ValorEnum("BO")]
        Boleano,
        [ValorEnum("LV")]
        ListaValores
    }
}
