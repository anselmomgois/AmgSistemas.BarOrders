using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AmgSistemas.BarOrders.Interfaces
{
    public interface IComandaRepository :IGeneric
    {
        string AbrirComanda(Models.Pedido pedido);

        void FazerPedido(List<Models.ItemPedido> itemsPedido, string identificadorComanda);

        void FinalizarPedido();
    }
}
