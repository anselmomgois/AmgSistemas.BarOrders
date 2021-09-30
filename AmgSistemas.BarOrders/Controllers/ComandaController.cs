using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AmgSistemas.BarOrders.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ComandaController : Controller
    {
        private readonly Interfaces.IComandaServices _comandaServices;

        public ComandaController(Interfaces.IComandaServices comandaServices)
        {
            _comandaServices = comandaServices;
        }

        [HttpPost()]
        public Models.RetornoGenerico Post(Models.Pedido pedido)
        {
            try
            {
            
                Models.RetornoGenerico objRetorno = new Models.RetornoGenerico();

               // objRetorno.retorno = _pedidoServices.GuardarPedido(pedido);
                objRetorno.codigo = 0;

                return objRetorno;
            }
            catch (Exception ex)
            {
                return new Models.RetornoGenerico() { codigo = 1, descricao = ex.ToString() };
            }
        }

        [Route("iniciar-atendimento")]
        [HttpPost()]
        public Models.RetornoGenerico Post(Models.Atendimento atendimento)
        {
            try
            {
                Models.RetornoGenerico objRetorno = new Models.RetornoGenerico();

                if (ModelState.IsValid)
                {

                    _comandaServices.IniciarAtendimento(atendimento.identificadorMesa, atendimento.identificadorFilial, atendimento.trabalhaPorMesa, atendimento.identificadorAtendente, 
                                                        atendimento.codigoPrefixoComanda, atendimento.trabalhaPorComanda);
                    objRetorno.codigo = 0;

                }
               

               
                

                return objRetorno;
            }
            catch (Execao.ExecaoNegocio ex)
            {
                return new Models.RetornoGenerico() { codigo =  ex.codigo.GetHashCode(), descricao = ex.descricao };
            }
            catch (Exception ex)
            {
                return new Models.RetornoGenerico() { codigo = 1, descricao = ex.ToString() };
            }
        }
    }
}
