using AmgSistemas.BarOrders.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AmgSistemas.BarOrders.Services
{
    public class MesaServices : Interfaces.IMesaServices
    {

        private readonly Interfaces.IMesaRepository _mesaRepository;

        public MesaServices(Interfaces.IMesaRepository mesaRepository)
        {
            _mesaRepository = mesaRepository;
        }

        public Mesa Buscar(string identificador)
        {
            return _mesaRepository.Buscar(identificador);
        }
    }
}
