using AmgSistemas.BarOrders.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AmgSistemas.BarOrders.Extensoes;

namespace AmgSistemas.BarOrders.Services
{
    public class MesaServices : Interfaces.IMesaServices
    {

        private readonly Interfaces.IMesaRepository _mesaRepository;
        private readonly Interfaces.IMesaAtendenteRepository _mesaAtendente;

        public MesaServices(Interfaces.IMesaRepository mesaRepository, Interfaces.IMesaAtendenteRepository mesaAtendente)
        {
            _mesaRepository = mesaRepository;
            _mesaAtendente = mesaAtendente;
        }

        public Mesa Buscar(string identificador)
        {
            var mesa = _mesaRepository.Buscar(identificador);

            if(mesa.codigoEstado == Enumeradores.EstadoMesa.Ocupado.RecuperarValor())
            {
                mesa.mesasAtendentes = _mesaAtendente.Buscar(identificador);
            }

            return mesa;
        }
    }
}
