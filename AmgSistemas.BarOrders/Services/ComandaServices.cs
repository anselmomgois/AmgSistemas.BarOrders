using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace AmgSistemas.BarOrders.Services
{
    public class ComandaServices : Interfaces.IComandaServices
    {

        private readonly Interfaces.IComandaRepository _comandaRepository;
        private readonly Interfaces.IMesaRepository _mesaRepository;
        private readonly Interfaces.IMesaAtendenteRepository _mesaAtendenteRepository;


        public ComandaServices(Interfaces.IComandaRepository comandaRepository, Interfaces.IMesaRepository mesaRepository, Interfaces.IMesaAtendenteRepository mesaAtendenteRepository)
        {
            _comandaRepository = comandaRepository;
            _mesaRepository = mesaRepository;
            _mesaAtendenteRepository = mesaAtendenteRepository;
        }

        public string IniciarAtendimento(string identificadorMesa, string identificadorFilial, bool trabalhaPorMesa, string identificadorFuncionario, string codPrefixoComanda)
        {
            string codigoComanda = string.Empty;

            var context = new BD.BancoContext();

            using (DbContextTransaction transaction = (DbContextTransaction)context.Database.BeginTransaction())
            {
                if (trabalhaPorMesa)
                {
                    if (_mesaRepository.MesaDisponivel(identificadorMesa))
                    {

                        try
                        {
                            _mesaRepository.AtualizarEstado(identificadorMesa, Enumeradores.EstadoMesa.Ocupado, ref context);

                            string identificadorMesaAtendente = _mesaAtendenteRepository.GerarAtendimento(identificadorFuncionario, identificadorMesa, _mesaAtendenteRepository.GerarChaveAcesso(), ref context);

                            codigoComanda = _comandaRepository.GerarCodigoComanda(identificadorFilial, codPrefixoComanda, identificadorMesaAtendente, ref context);

                            transaction.Commit();
                        }
                        catch (Exception ex)
                        {
                            transaction.Rollback();
                            throw;
                        }

                    }
                    else
                    {
                        throw new Execao.ExecaoNegocio(Enumeradores.CodigosErros.ErroNegocio, "Mesa não se encontra disponível para abertura.");
                    }
                }
                else
                {
                    try
                    {
                        string identificadorMesaAtendente = _mesaAtendenteRepository.GerarAtendimento(identificadorFuncionario, identificadorMesa, _mesaAtendenteRepository.GerarChaveAcesso(), ref context);

                        codigoComanda = _comandaRepository.GerarCodigoComanda(identificadorFilial, codPrefixoComanda, identificadorMesaAtendente, ref context);

                        transaction.Commit();
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        throw;
                    }
                }
            }

            return codigoComanda;
        }
    }
}
