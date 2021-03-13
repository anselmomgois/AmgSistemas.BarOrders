using AmgSistemas.BarOrders.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AmgSistemas.BarOrders.Services
{
    public class GrupoProdutoServices : Interfaces.IGrupoProdutoServices
    {

        private readonly Interfaces.IGrupoProdutoRepository _grupoProdutoRepository;

        public GrupoProdutoServices(Interfaces.IGrupoProdutoRepository grupoProdutoRepository)
        {

            _grupoProdutoRepository = grupoProdutoRepository;
        }

        public List<GrupoProduto> Buscar(string identificadorEmpresa)
        {
            return _grupoProdutoRepository.Buscar(identificadorEmpresa);
        }
    }
}
