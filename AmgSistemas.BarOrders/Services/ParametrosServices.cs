using AmgSistemas.BarOrders.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AmgSistemas.BarOrders.Services
{
    public class ParametrosServices : Interfaces.IParametroServices
    {
        private readonly Interfaces.IParametroRepository _parametroRepository;

        public static List<Models.ParametroEmpresa> _parametros;
        private static readonly object _sync;
        private static readonly object _syncInstancia;


        public ParametrosServices(Interfaces.IParametroRepository parametroRepository)
        {
            _parametroRepository = parametroRepository;
        }

        public static List<Models.ParametroEmpresa> parametros
        {
            get
            {
                if (_parametros == null)
                {
                    lock (_syncInstancia)
                    {

                        if (_parametros == null)
                        {
                            _parametros = new List<ParametroEmpresa>();
                        }
                    }
                }
                return _parametros;
            }
        }

        public Parametro BuscarParametro(string identificadorEmpresa, string identificadorFilial, string codigoParametro)
        {

            BuscarParametrosBanco(identificadorEmpresa, identificadorFilial);


            return _parametros.Find(p => p.identificadorEmpresa == identificadorEmpresa && p.identificadorFilial == identificadorFilial)?.parametros?.Find(ph => ph.codigo == codigoParametro);
        }

        public List<Parametro> BuscarParametros(string identificadorEmpresa, string identificadorFilial)
        {

            BuscarParametrosBanco(identificadorEmpresa, identificadorFilial);


            var parametrosRetorno = _parametros.FindAll(pa => pa.identificadorEmpresa == identificadorEmpresa &&
                                                       (pa.identificadorFilial == identificadorFilial || string.IsNullOrEmpty(pa.identificadorFilial)))?.Select(p => p.parametros)?.ToList();

            List<Models.Parametro> parametros = new List<Parametro>();

            parametrosRetorno.ForEach(pr =>
            {
                pr.ForEach(ph =>
                {
                    parametros.Add(ph);
                });

            });

            return parametros;
        }

        private void BuscarParametrosBanco(string identificadorEmpresa, string identificadorFilial)
        {
            if (!_parametros.Exists(pa => pa.identificadorFilial == identificadorFilial))
            {
                lock (_sync)
                {
                    if (!_parametros.Exists(pa => pa.identificadorFilial == identificadorFilial))
                    {
                        var parametrosEmpresa = _parametroRepository.Buscar(identificadorEmpresa, identificadorFilial);

                        _parametros.Add(new ParametroEmpresa
                        {
                            identificadorFilial = identificadorFilial,
                            identificadorEmpresa = identificadorEmpresa,
                            parametros = parametrosEmpresa
                        });
                    }
                }
            }
        }
    }
}
