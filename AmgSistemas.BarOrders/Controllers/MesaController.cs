using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AmgSistemas.BarOrders.Extensoes;
namespace AmgSistemas.BarOrders.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MesaController : Controller
    {
        private readonly Interfaces.IMesaServices _mesaServices;

        public MesaController(Interfaces.IMesaServices mesaServices)
        {
            _mesaServices = mesaServices;
        }

        [HttpGet("{id}/{codigo}/{identificadorEmpresa}/{identificadorFilial}/{senha?}")]
        public Models.RetornoGenerico Get(string id, string codigo, string identificadorEmpresa, string identificadorFilial, string senha)
        {
            try
            {
                Models.RetornoGenerico objRetorno = new Models.RetornoGenerico();

                objRetorno.retorno = _mesaServices.Buscar(id, senha, codigo, identificadorEmpresa,identificadorFilial);
                objRetorno.codigo = 0;

                return objRetorno;
            }
            catch (Execao.ExecaoNegocio ex)
            {
                if (ex.codigo == Enumeradores.CodigosErros.SolicitarSenha)
                    return new Models.RetornoGenerico() { codigo = Convert.ToInt32(Enumeradores.CodigosErros.SolicitarSenha.RecuperarValor()), descricao = ex.ToString() };
                else
                    return new Models.RetornoGenerico() { codigo = Convert.ToInt32(ex.codigo.RecuperarValor()), descricao = ex.ToString() };
            }
            catch (Exception ex)
            {
                return new Models.RetornoGenerico() { codigo = 1, descricao = ex.ToString() };
            }
        }
    }
}
