using AmgSistemas.BarOrders.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AmgSistemas.BarOrders.Repository
{
    public class GrupoProdutoRepository : Interfaces.IGrupoProdutoRepository
    {

        private readonly BD.BancoContext _contexto;

        public GrupoProdutoRepository(BD.BancoContext contexto)
        {
            _contexto = contexto;
        }

        public List<GrupoProduto> Buscar(string identificadorEmpresa)
        {
            if(!string.IsNullOrEmpty(identificadorEmpresa))
            {

                return (from BD.Models.AGBO_TGRUPO_PRODUTO gp in _contexto.AGBO_TGRUPO_PRODUTO
                        where gp.ID_EMPRESA == identificadorEmpresa
                        select new Models.GrupoProduto()
                        {
                            codigo = gp.COD_GRUPO_PRODUTO,
                            descricao = gp.DES_GRUPO_PRODUTO,
                            identificador = gp.ID_GRUPO_PRODUTO
                        }).ToList();
            }

            return new List<GrupoProduto>();
        }
    }
}
