using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace AmgSistemas.BarOrders.BD.Models
{
    public class AGBO_TTIPO_FUNCIONARIO
    {
        public string ID_TIPO_FUNCIONARIO { get; set; }
        [Required()]
        public string COD_TIPO_FUNCIONARIO { get; set; }
        [Required()]
        public string DES_TIPO_FUNCIONARIO { get; set; }

        public ICollection<AGBO_TFUNCIONARIO> AGBO_TFUNCIONARIO { get; set; }
    }
}
