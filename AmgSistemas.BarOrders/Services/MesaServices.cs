using AmgSistemas.BarOrders.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AmgSistemas.BarOrders.Extensoes;
using AmgSistemas.BarOrders.Execao;
namespace AmgSistemas.BarOrders.Services
{
    public class MesaServices : Interfaces.IMesaServices
    {

        private readonly Interfaces.IMesaRepository _mesaRepository;
        private readonly Interfaces.IMesaAtendenteRepository _mesaAtendenteRepository;
        private readonly Interfaces.IDispositivoRepository _dispositivoRepository;
        private readonly Interfaces.IParametroServices _parametrosServices;

        public MesaServices(Interfaces.IMesaRepository mesaRepository, Interfaces.IMesaAtendenteRepository mesaAtendente,
                            Interfaces.IDispositivoRepository dispositivoRepository, Interfaces.IParametroServices parametroServices)
        {
            _mesaRepository = mesaRepository;
            _mesaAtendenteRepository = mesaAtendente;
            _dispositivoRepository = dispositivoRepository;
            _parametrosServices = parametroServices;
        }

        public Mesa Buscar(string identificador, string senha, string codigoDispositivo, string identificadorEmpresa, string identificadorFilial)
        {
            var mesa = _mesaRepository.Buscar(identificador);

            if (mesa.codigoEstado == Enumeradores.EstadoMesa.Ocupado.RecuperarValor())
            {
                mesa.mesasAtendentes = _mesaAtendenteRepository.Buscar(identificador);

                if (mesa.mesasAtendentes?.Count > 0)
                {
                    if (!string.IsNullOrEmpty(senha))
                    {
                        mesa.mesaAtendenteCorrente = mesa.mesasAtendentes.Find(ma => ma.codigoChaveAcesso == senha);

                        if (mesa.mesaAtendenteCorrente == null)
                        {
                            throw new ExecaoNegocio(Enumeradores.CodigosErros.ErroNegocio, "Senha incorreta");
                        }

                        var dispositivos = _dispositivoRepository.Buscar(mesa.mesaAtendenteCorrente.identificador);

                        if (dispositivos == null)
                        {
                            _dispositivoRepository.Registrar(mesa.mesaAtendenteCorrente.identificador, codigoDispositivo);
                        }
                        else
                        {
                          var parametro =  _parametrosServices.BuscarParametro(identificadorEmpresa, identificadorFilial, Enumeradores.CodigosParametros.MultiplasComandaPorMesa.RecuperarValor());
                            var existeDispositivo = dispositivos.Exists(di => di.codigo == codigoDispositivo);

                            if (!existeDispositivo)
                            {
                                if (parametro != null && parametro.valor == "1")
                                {
                                    _dispositivoRepository.Registrar(mesa.mesaAtendenteCorrente.identificador, codigoDispositivo);
                                }
                                else
                                {
                                    throw new ExecaoNegocio(Enumeradores.CodigosErros.ErroNegocio, "Mesa associada a outro dispositivo");
                                }
                            }
                        }

                    }
                    else
                    {
                        mesa.mesaAtendenteCorrente = mesa.mesasAtendentes.FirstOrDefault();

                        var dispositivo = _dispositivoRepository.Buscar(mesa.mesaAtendenteCorrente.identificador);

                        if (dispositivo == null)
                        {
                            _dispositivoRepository.Registrar(mesa.mesaAtendenteCorrente.identificador, codigoDispositivo);
                        }
                        else
                        {
                           throw new Execao.ExecaoNegocio(Enumeradores.CodigosErros.SolicitarSenha, "Favor Informar a Senha da Comanda.");                            
                        }
                    }
                }
            }

            return mesa;
        }
    }
}
