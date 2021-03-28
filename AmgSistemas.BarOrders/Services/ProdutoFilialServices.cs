using AmgSistemas.BarOrders.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AmgSistemas.BarOrders.Interfaces;

namespace AmgSistemas.BarOrders.Services
{
    public class ProdutoFilialServices : IProdutoFilialServices
    {
        private readonly IProdutoFilialRepository _produtoFilialRepository;

        public ProdutoFilialServices(IProdutoFilialRepository produtoFilialRepository)
        {
            _produtoFilialRepository = produtoFilialRepository;
        }
        public List<Models.ProdutoFilial> Buscar(string idEmpresa, string idFilial)
        {
            return _produtoFilialRepository.Buscar(idEmpresa,idFilial);
        }
    }
}
