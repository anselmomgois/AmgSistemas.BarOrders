using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AmgSistemas.BarOrders.BD.Models
{
    [Table("AGBO_TFILIAL")]
    public class AGBO_TFILIAL
    {
        public string ID_FILIAL { get; set; }
        [ForeignKey("AGBO_TEMPRESA")]
        public string ID_EMPRESA { get; set; }
        public string COD_FILIAL { get; set; }
        public string DES_FILIAL { get; set; }
        public bool BOL_ACTIVO { get; set; }
        public DateTime DTH_REGISTRO { get; set; }
        public bool BOL_TRABALHA_POR_MESA { get; set; }
        public bool BOL_SOLICITAR_TELEFONE { get; set; }
        public string COD_PREFIXO_COMANDA { get; set; }
        public AGBO_TEMPRESA AGBO_TEMPRESA { get; set; }

        public ICollection<AGBO_TCOMANDA> AGBO_TCOMANDA { get; set; }

        public ICollection<AGBO_TFILIAL_FUNCIONARIO> AGBO_TFILIAL_FUNCIONARIO { get; set; }

        public ICollection<AGBO_TMESA> AGBO_TMESA { get; set; }

        public ICollection<AGBO_TMESA_ATENDENTE> AGBO_TMESA_ATENDENTE { get; set; }

        public ICollection<AGBO_TPARAMETRO_VALOR> AGBO_TPARAMETRO_VALOR { get; set; }

        public ICollection<AGBO_TPRODUTO_FILIAL> AGBO_TPRODUTO_FILIAL { get; set; }
    }
}
