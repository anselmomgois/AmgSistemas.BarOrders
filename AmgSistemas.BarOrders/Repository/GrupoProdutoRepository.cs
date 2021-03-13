using AmgSistemas.BarOrders.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AmgSistemas.BarOrders.Repository
{
    public class GrupoProdutoRepository : Interfaces.IGrupoProdutoRepository
    {
        public List<GrupoProduto> Buscar(string identificadorEmpresa)
        {
            if(!string.IsNullOrEmpty(identificadorEmpresa))
            {

                BD.BancoContext objBD = new BD.BancoContext();

                return (from BD.Models.AGBO_TGRUPO_PRODUTO gp in objBD.AGBO_TGRUPO_PRODUTO
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
