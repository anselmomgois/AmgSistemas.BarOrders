using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AmgSistemas.BarOrders.Models
{
    public class MesaAtendente
    {
        public string identificador { get; set; }
        public DateTime dataRegistro { get; set; }
        public string telefone { get; set; }
        public string codigoComanda { get; set; }
        public string nomeAtendente { get; set; }
        public string codigoChaveAcesso { get; set; }
       
    }
}
