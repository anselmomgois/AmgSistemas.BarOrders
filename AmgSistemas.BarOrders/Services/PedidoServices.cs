using AmgSistemas.BarOrders.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AmgSistemas.BarOrders.Services
{
    public class PedidoServices : Interfaces.IPedidoServices
    {
        private readonly Interfaces.IComandaRepository _comandaRepository;

        public PedidoServices(Interfaces.IComandaRepository comandaRepository)
        {
            _comandaRepository = comandaRepository;
        }

        public Models.PedidoSimplificado GuardarPedido(Pedido pedido)
        {
            Models.PedidoSimplificado _pedidoSimplificado = new PedidoSimplificado {
               identificadorComanda =  pedido.identificadorComanda
            };

            if(string.IsNullOrEmpty(_pedidoSimplificado.identificadorComanda))
            {
                _pedidoSimplificado.codigoComanda = GerarCodigoComanda();
                _pedidoSimplificado.identificadorComanda = _comandaRepository.AbrirComanda(pedido);
            }

            _comandaRepository.FazerPedido(pedido.itensPedido, _pedidoSimplificado.identificadorComanda);

            _comandaRepository.FinalizarPedido();

            return _pedidoSimplificado;
        }

        private string GerarCodigoComanda()
        {

            return string.Empty;
        }
    }
}
