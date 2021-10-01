using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AmgSistemas.BarOrders.Interfaces
{
    public interface IComandaRepository :IGeneric
    {
        string AbrirComanda(Models.Pedido pedido, ref BD.BancoContext contexto);

        void FazerPedido(List<Models.ItemPedido> itemsPedido, string identificadorComanda, ref BD.BancoContext contexto);


        string GerarCodigoComanda(string identificadorFilial, string codigoPrefixo, string identificadorMesaAtendente, ref BD.BancoContext contexto);

    }
}
