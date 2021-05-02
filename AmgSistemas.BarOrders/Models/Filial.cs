using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AmgSistemas.BarOrders.Models
{
    public class Filial
    {
        public string identificador { get; set; }
        public string codigo { get; set; }
        public string descricao { get; set; }
        public bool trabalhaPorMesa { get; set; }
        public bool solicitarTelefone { get; set; }
        public Empresa empresa { get; set; }
    }
}
