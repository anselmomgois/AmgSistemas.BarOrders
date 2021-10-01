using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AmgSistemas.BarOrders.Models
{
    public class ParametroEmpresa
    {
        public string identificadorEmpresa { get; set; }
        public string identificadorFilial { get; set; }
        public List<Parametro> parametros { get; set; }
    }
}
