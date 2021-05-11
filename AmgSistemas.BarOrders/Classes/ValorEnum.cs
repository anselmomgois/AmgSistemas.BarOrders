using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AmgSistemas.BarOrders.Classes
{

    [AttributeUsage(AttributeTargets.Field, AllowMultiple = false)]
    public class ValorEnum : Attribute
    {

        public string Valor { get; set; }

        public ValorEnum(string valor)
        {
            this.Valor = valor;
        }

    }
}
