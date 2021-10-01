using AmgSistemas.BarOrders.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore;
using System.Data.SqlClient;

namespace AmgSistemas.BarOrders.Services
{
    public class PedidoServices : Interfaces.IPedidoServices
    {
        private readonly Interfaces.IComandaRepository _comandaRepository;
        public IConfiguration _configuration { get; }

        public PedidoServices(Interfaces.IComandaRepository comandaRepository, IConfiguration configuration)
        {
            _comandaRepository = comandaRepository;
            _configuration = configuration;
        }

        public Models.PedidoSimplificado GuardarPedido(Pedido pedido)
        {
            Models.PedidoSimplificado _pedidoSimplificado = new PedidoSimplificado {
               identificadorComanda =  pedido.identificadorComanda
            };

            using (SqlConnection con = new SqlConnection(_configuration.GetConnectionString("DbContext")))
            {
                con.Open();

                using (SqlTransaction transaction = con.BeginTransaction())
                {
                    var context = new BD.BancoContext(transaction.Connection);


                    context.Database.UseTransaction(transaction);

                    try
                    {
                        if (string.IsNullOrEmpty(_pedidoSimplificado.identificadorComanda))
                        {
                            _pedidoSimplificado.codigoComanda = GerarCodigoComanda();
                            _pedidoSimplificado.identificadorComanda = _comandaRepository.AbrirComanda(pedido, ref context);
                        }

                        _comandaRepository.FazerPedido(pedido.itensPedido, _pedidoSimplificado.identificadorComanda, ref context);

                        transaction.Commit();
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        throw;
                    }
                }
            }
            return _pedidoSimplificado;
        }

        private string GerarCodigoComanda()
        {

            return string.Empty;
        }
    }
}
