using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AmgSistemas.BarOrders.Classes;

namespace AmgSistemas.BarOrders.Enumeradores
{
    public enum CodigosErros
    {
        [ValorEnum("1")]
        ErroDefault,
        [ValorEnum("2")]
        ErroNegocio,
        [ValorEnum("0")]
        SemErro
    }
}
