﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AmgSistemas.BarOrders.BD.Models
{
    public class AGBO_TMESA_ATENDENTE
    {
        public string ID_MESA_ATENDENTE { get; set; }
        public string ID_MESA { get; set; }
        public string ID_FUNCIONARIO { get; set; }
        public DateTime DTH_REGISTRO { get; set; }
        public bool BOL_CORRENTE { get; set; }
        public string DES_TELEFONE { get; set; }
        public string COD_COMANDA { get; set; }

        public AGBO_TMESA AGBO_TMESA { get; set; }
        public AGBO_TFUNCIONARIO AGBO_TFUNCIONARIO { get; set; }
    }
}