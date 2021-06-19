using AmgSistemas.BarOrders.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AmgSistemas.BarOrders.Extensoes;
using AmgSistemas.BarOrders.Enumeradores;

namespace AmgSistemas.BarOrders.Repository
{
    public class MesaRepository : Interfaces.IMesaRepository
    {
        public void AtualizarEstado(string identificador, EstadoMesa estado)
        {
            BD.BancoContext objBD = new BD.BancoContext();

            var mesa = (from BD.Models.AGBO_TMESA m in objBD.AGBO_TMESA
                        where m.ID_MESA == identificador && m.BOL_ATIVO
                        select m).FirstOrDefault();

            if(mesa != null)
            {
                mesa.COD_ESTADO = estado.RecuperarValor();
                mesa.DTH_REGISTRO = DateTime.Now;

                objBD.SaveChanges();
            }           

        }

        public void AtualizarEstado(string identificador, EstadoMesa estado, ref BD.BancoContext contexto)
        {
            BD.BancoContext objBD = contexto;

            var mesa = (from BD.Models.AGBO_TMESA m in objBD.AGBO_TMESA
                        where m.ID_MESA == identificador && m.BOL_ATIVO
                        select m).FirstOrDefault();

            if (mesa != null)
            {
                mesa.COD_ESTADO = estado.RecuperarValor();
                mesa.DTH_REGISTRO = DateTime.Now;

                objBD.SaveChanges();
            }

        }

        public Mesa Buscar(string identificador)
        {
            if (!string.IsNullOrEmpty(identificador))
            {
                BD.BancoContext objBD = new BD.BancoContext();

                var mesa = (from BD.Models.AGBO_TMESA m in objBD.AGBO_TMESA
                            where m.ID_MESA == identificador && m.BOL_ATIVO
                            select new Mesa()
                            {
                                identificador = m.ID_MESA,
                                codigo = m.COD_MESA,
                                codigoEstado = m.COD_ESTADO,
                                ativo = m.BOL_ATIVO
                            }).FirstOrDefault();

                if (mesa.codigoEstado == Enumeradores.EstadoMesa.Ocupado.RecuperarValor())
                {
                    mesa.mesasAtendentes = (from BD.Models.AGBO_TMESA_ATENDENTE ma in objBD.AGBO_TMESA_ATENDENTE
                                            join BD.Models.AGBO_TFUNCIONARIO f in objBD.AGBO_TFUNCIONARIO on ma.ID_FUNCIONARIO equals f.ID_FUNCIONARIO
                                            where ma.ID_MESA == identificador && ma.BOL_CORRENTE
                                            select new MesaAtendente
                                            {
                                                dataRegistro = ma.DTH_REGISTRO,
                                                identificador = ma.ID_MESA_ATENDENTE,
                                                nomeAtendente = f.DES_NOME
                                            }).ToList();
                }

                return mesa;
            }

            return new Mesa();
        }

        public bool MesaDisponivel(string identificador)
        {
            BD.BancoContext objBD = new BD.BancoContext();

            var disponivel = (from BD.Models.AGBO_TMESA m in objBD.AGBO_TMESA
                              where m.ID_MESA == identificador && m.BOL_ATIVO && m.COD_ESTADO == Enumeradores.EstadoMesa.Livre.RecuperarValor()
                              select m).Count();

            return Convert.ToBoolean(disponivel);
        }
    }
}
