using AmgSistemas.BarOrders.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AmgSistemas.BarOrders.Repository
{

    public class ComandaRepository : Interfaces.IComandaRepository
    {

        private readonly BD.BancoContext _contexto;
        private Int32 _tentativasGerarComanda = 0;

        public ComandaRepository(BD.BancoContext contexto)
        {
            _contexto = contexto;
        }

        public string AbrirComanda(Pedido pedido, ref BD.BancoContext contexto)
        {
            string _identificadorcomanda = Guid.NewGuid().ToString();


            contexto.AGBO_TCOMANDA.Add(new BD.Models.AGBO_TCOMANDA
            {
                COD_COMANDA = pedido.codigoComanda,
                DTH_REGISTRO = DateTime.Now,
                ID_COMANDA = _identificadorcomanda,
                ID_MESA = pedido.identificadorMesa,
                ID_MESA_ATENDENTE = pedido.identificadorMesaAtendente
            });

            contexto.SaveChanges();

            return _identificadorcomanda;
        }

        public void FazerPedido(List<ItemPedido> itemsPedido, string identificadorComanda, ref BD.BancoContext contexto)
        {
            
            foreach (var item in itemsPedido)
            {
                contexto.AGBO_TITEM_COMANDA.Add(new BD.Models.AGBO_TITEM_COMANDA
                {
                    ID_COMANDA = identificadorComanda,
                    DTH_REGISTRO = DateTime.Now,
                    ID_ITEM_COMANDA = Guid.NewGuid().ToString(),
                    ID_PRODUTO_FILIAL = item.identificadorProdutoFilial,
                    NUM_QUANTIDADE = item.quantidade
                });
            }
        }

        public string GerarCodigoComanda(string identificadorFilial, string codigoPrefixo, string identificadorMesaAtendente, ref BD.BancoContext contexto)
        {
            string codigo = string.Empty;

            try
            {
                try
                {

                    codigo = (from BD.Models.AGBO_TMESA_ATENDENTE ma in contexto.AGBO_TMESA_ATENDENTE
                              where ma.ID_FILIAL == identificadorFilial
                              select Convert.ToInt32(ma.COD_COMANDA)).Max().ToString();

                    codigo = Convert.ToString(Convert.ToInt32(codigo) + 1).PadLeft(6);
                }
                catch
                {
                    codigo = "000001";
                }

                var mesaAtendente = (from BD.Models.AGBO_TMESA_ATENDENTE ma in contexto.AGBO_TMESA_ATENDENTE
                                     where ma.ID_MESA_ATENDENTE == identificadorMesaAtendente
                                     select ma).FirstOrDefault();

                if (mesaAtendente != null)
                {
                    mesaAtendente.COD_COMANDA = codigo;
                    contexto.SaveChanges();
                }

                if (!string.IsNullOrEmpty(codigoPrefixo))
                {
                    codigo = string.Format("{0}-{1}", codigoPrefixo, codigo);
                }
            }
            catch(Exception ex)
            {
                _tentativasGerarComanda += 1;

                if (_tentativasGerarComanda > 3)
                {
                    throw;
                }
                else
                {
                    codigo = GerarCodigoComanda(identificadorFilial, codigoPrefixo, identificadorMesaAtendente, ref contexto);
                }
            }

            return codigo;
        }


    }

}
