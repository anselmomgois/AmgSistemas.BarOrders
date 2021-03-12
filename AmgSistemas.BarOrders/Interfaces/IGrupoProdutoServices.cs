using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AmgSistemas.BarOrders.Interfaces
{
    interface IGrupoProdutoServices:IGeneric
    {

        List<Models.GrupoProduto> Buscar(string identificadorFilial);
    }
}
