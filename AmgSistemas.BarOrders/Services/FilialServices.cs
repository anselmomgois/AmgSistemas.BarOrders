using AmgSistemas.BarOrders.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AmgSistemas.BarOrders.Services
{
    public class FilialServices : Interfaces.IFilialServices
    {
        private readonly Interfaces.IFilialRepository _filialRepository;

        public FilialServices(Interfaces.IFilialRepository filialRepository)
        {

            _filialRepository = filialRepository;
        }

        public Filial Buscar(string identificador)
        {

            Models.Filial filial = _filialRepository.Buscar(identificador);


            return filial;
        }
    }
}
