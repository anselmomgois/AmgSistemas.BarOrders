using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AmgSistemas.BarOrders.Interfaces
{
    public interface IProdutoFilialRepository :IGeneric
    {
       List<Models.ProdutoFilial> Buscar(string idEmpresa, string idFilial);
    }
}
