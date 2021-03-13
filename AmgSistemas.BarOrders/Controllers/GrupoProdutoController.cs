using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AmgSistemas.BarOrders.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GrupoProdutoController : ControllerBase
    {
        private readonly Interfaces.IGrupoProdutoServices _grupoProdutoServices;

        public GrupoProdutoController(Interfaces.IGrupoProdutoServices grupoProdutoServices)
        {
            _grupoProdutoServices = grupoProdutoServices;
        }

        [HttpGet("{idEmpresa}")]
        public Models.RetornoGenerico Get(string idEmpresa)
        {
            try
            {
                Models.RetornoGenerico objRetorno = new Models.RetornoGenerico();

                objRetorno.retorno = _grupoProdutoServices.Buscar(idEmpresa);
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
