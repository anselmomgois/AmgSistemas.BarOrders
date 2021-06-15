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
    }
}
