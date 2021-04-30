using AmgSistemas.BarOrders.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AmgSistemas.BarOrders.Repository
{
    public class ProdutoFilialRepository : Interfaces.IProdutoFilialRepository
    {
        public List<Models.ProdutoFilial> Buscar(string idEmpresa, string idFilial)
        {

            if (!string.IsNullOrEmpty(idFilial) && !string.IsNullOrEmpty(idEmpresa))
            {
                BD.BancoContext objBD = new BD.BancoContext();

                return (from BD.Models.AGBO_PRODUTO p in objBD.AGBO_PRODUTO
                        join BD.Models.AGBO_TPRODUTO_FILIAL pf in objBD.AGBO_TPRODUTO_FILIAL on p.ID_PRODUTO equals pf.ID_PRODUTO
                        join BD.Models.AGBO_TFILIAL f in objBD.AGBO_TFILIAL on pf.ID_FILIAL equals f.ID_FILIAL
                        join BD.Models.AGBO_TGRUPO_PRODUTO gp in objBD.AGBO_TGRUPO_PRODUTO on p.ID_GRUPO_PRODUTO equals gp.ID_GRUPO_PRODUTO
                        where f.ID_FILIAL == idFilial && f.ID_EMPRESA == idEmpresa
                        orderby gp.DES_GRUPO_PRODUTO
                        select new Models.ProdutoFilial()
                        {
                            codigo = p.COD_PRODUTO,
                            descricao = p.DES_PRODUTO,
                            identificador = p.ID_PRODUTO,
                            observacao = p.OBS_PRODUTO,
                            quantidade = pf.NUM_QUANTIDADE,
                            valor = pf.NUM_VALOR,
                            imagem = p.BOL_IMAGEM,
                            identificadorGrupoProduto = gp.ID_GRUPO_PRODUTO,
                            descricaoGrupoProduto = gp.DES_GRUPO_PRODUTO
                        }).ToList();


            }

            return new List<ProdutoFilial>();
        }
    }
}
