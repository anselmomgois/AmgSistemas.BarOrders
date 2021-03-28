using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AmgSistemas.BarOrders.Models
{
    public class Produto
    {
        public string identificador { get; set; }
        public string codigo { get; set; }
        public string descricao { get; set; }
        public string observacao { get; set; }
        public byte[] imagem { get; set; }
    }
}
