using AmgSistemas.BarOrders.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AmgSistemas.BarOrders.Repository
{
    public class ComandaRepository : Interfaces.IComandaRepository
    {

        private BD.BancoContext objBD = null;

        public string AbrirComanda(Pedido pedido)
        {
            string _identificadorcomanda = Guid.NewGuid().ToString();

            objBD = new BD.BancoContext();

            objBD.AGBO_TCOMANDA.Add(new BD.Models.AGBO_TCOMANDA
            {
                COD_COMANDA = pedido.codigoComanda,
                DTH_REGISTRO = DateTime.Now,
                ID_COMANDA = _identificadorcomanda,
                ID_MESA = pedido.identificadorMesa,
                ID_MESA_ATENDENTE = pedido.identificadorMesaAtendente
            });

            return _identificadorcomanda;
        }

        public void FazerPedido(List<ItemPedido> itemsPedido, string identificadorComanda)
        {
            if (objBD == null) objBD = new BD.BancoContext();

           foreach(var item in itemsPedido)
            {
                objBD.AGBO_TITEM_COMANDA.Add(new BD.Models.AGBO_TITEM_COMANDA
                {
                    ID_COMANDA = identificadorComanda,
                    DTH_REGISTRO = DateTime.Now,
                    ID_ITEM_COMANDA = Guid.NewGuid().ToString(),
                    ID_PRODUTO_FILIAL = item.identificadorProdutoFilial,
                    NUM_QUANTIDADE = item.quantidade
                });
            }
        }

        public void FinalizarPedido()
        {
            objBD.SaveChanges();
        }
        
    }
}
