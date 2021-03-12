﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AmgSistemas.BarOrders.Interfaces
{
    interface IGrupoProdutoRepository:IGeneric
    {
        List<Models.GrupoProduto> Buscar(string identificadorFilial);
    }
}
