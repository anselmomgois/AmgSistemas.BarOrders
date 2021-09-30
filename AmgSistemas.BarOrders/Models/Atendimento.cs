using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AmgSistemas.BarOrders.Models
{
    public class Atendimento
    {
        [Required(ErrorMessage = "Obrigatório informar a filial")]
        public string identificadorFilial { get; set; }
        public string identificadorMesa { get; set; }
        [Required(ErrorMessage = "Obrigatório informar o atendente")]
        public string identificadorAtendente { get; set; }
        public bool trabalhaPorMesa { get; set; }
        public bool trabalhaPorComanda { get; set; }
        public string codigoPrefixoComanda { get; set; }

    }
}
