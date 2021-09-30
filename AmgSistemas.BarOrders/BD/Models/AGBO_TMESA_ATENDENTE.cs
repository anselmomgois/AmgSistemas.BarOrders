using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AmgSistemas.BarOrders.BD.Models
{
    public class AGBO_TMESA_ATENDENTE
    {
        public string ID_MESA_ATENDENTE { get; set; }
        [ForeignKey("AGBO_TMESA")]
        public string ID_MESA { get; set; }
        [ForeignKey("AGBO_TFILIAL")]
        public string ID_FILIAL { get; set; }
        [ForeignKey("AGBO_TFUNCIONARIO")]
        public string ID_FUNCIONARIO { get; set; }
        public DateTime DTH_REGISTRO { get; set; }
        public bool BOL_CORRENTE { get; set; }
        public string DES_TELEFONE { get; set; }
        public string COD_COMANDA { get; set; }
        public string COD_CHAVE_ACESSO { get; set; }
        public AGBO_TMESA AGBO_TMESA { get; set; }
        public AGBO_TFILIAL AGBO_TFILIAL { get; set; }
        public AGBO_TFUNCIONARIO AGBO_TFUNCIONARIO { get; set; }
        public ICollection<AGBO_TCOMANDA> AGBO_TCOMANDA { get; set; }
    }
}
