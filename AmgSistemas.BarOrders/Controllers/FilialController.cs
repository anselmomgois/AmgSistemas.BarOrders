using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AmgSistemas.BarOrders.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FilialController : ControllerBase
    {
        private readonly Interfaces.IFilialServices _filialServices;

        public FilialController(Interfaces.IFilialServices filialServices)
        {
            _filialServices = filialServices;
        }

        [HttpGet("{id}")]
        public Models.RetornoGenerico Get(string id)
        {
            try
            {
                Models.RetornoGenerico objRetorno = new Models.RetornoGenerico();
                
                objRetorno.retorno = _filialServices.Buscar(id);
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
