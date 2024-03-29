﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace AmgSistemas.BarOrders.BD.Models
{
    public class AGBO_TEMPRESA
    {
        public string ID_EMPRESA { get; set; }
        [Required()]
        public string COD_EMPRESA { get; set; }
        [Required()]
        public string DES_EMPRESA { get; set; }
        public byte[] BOL_IMAGEM { get; set; }
        [Required()]
        public bool BOL_ACTIVO { get; set; }
        [Required()]
        public DateTime DTH_REGISTRO { get; set; }

        public ICollection<AGBO_TFILIAL> AGBO_TFILIAL { get; set; }
        public ICollection<AGBO_TPRODUTO> AGBO_TPRODUTO { get; set; }
        public ICollection<AGBO_TGRUPO_PRODUTO> AGBO_TGRUPO_PRODUTO { get; set; }
        public ICollection<AGBO_TPARAMETRO_VALOR> AGBO_TPARAMETRO_VALOR { get; set; }
    }
}
