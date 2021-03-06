using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AmgSistemas.BarOrders.Interfaces;

namespace AmgSistemas.BarOrders.Controllers
{
    public class ProdutoFilialController : ControllerBase
    {
        private readonly IProdutoFilialServices _produtoFilialServices;

        public ProdutoFilialController(IProdutoFilialServices produtoFilialServices)
        {
            _produtoFilialServices = produtoFilialServices;
        }

        [HttpGet("{idEmpresa}/{idFilial}")]
        public Models.RetornoGenerico Get(string idEmpresa, string idFilial)
        {

            try
            {
                Models.RetornoGenerico objRetorno = new Models.RetornoGenerico();

                if (!string.IsNullOrEmpty(idFilial) && !string.IsNullOrEmpty(idEmpresa))
                {

                    objRetorno.retorno = _produtoFilialServices.Buscar(idEmpresa, idFilial);
                    objRetorno.codigo = 0;
                }
                return objRetorno;
            }
            catch (Exception ex)
            {
                return new Models.RetornoGenerico() { codigo = 1, descricao = ex.ToString() };
            }
        }
    }
}
