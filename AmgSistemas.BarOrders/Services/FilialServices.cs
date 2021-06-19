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
        private readonly Interfaces.IParametroRepository _parametroRepository;

        public FilialServices(Interfaces.IFilialRepository filialRepository, Interfaces.IParametroRepository parametroRepository)
        {

            _filialRepository = filialRepository;
            _parametroRepository = parametroRepository;
        }

        public Filial Buscar(string identificador)
        {
            var filial = _filialRepository.Buscar(identificador);
            filial.parametros = _parametroRepository.Buscar(filial.empresa.identificador, identificador);
           
            return filial;
        }
    }
}
