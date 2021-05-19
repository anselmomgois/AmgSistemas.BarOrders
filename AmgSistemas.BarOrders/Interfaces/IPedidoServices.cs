using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AmgSistemas.BarOrders.Interfaces
{
    public interface IPedidoServices :IGeneric
    {
        Models.PedidoSimplificado GuardarPedido(Models.Pedido pedido);

    }
}
