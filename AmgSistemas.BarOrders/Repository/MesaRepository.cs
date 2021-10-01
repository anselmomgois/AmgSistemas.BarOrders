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
        private readonly BD.BancoContext _contexto;

        public MesaRepository(BD.BancoContext contexto)
        {

            _contexto = contexto;
        }

        public void AtualizarEstado(string identificador, EstadoMesa estado)
        {
             var mesa = _contexto.AGBO_TMESA.FirstOrDefault(m => m.ID_MESA == identificador);

            if (mesa != null)
            {
                mesa.COD_ESTADO = estado.RecuperarValor();
                mesa.DTH_REGISTRO = DateTime.Now;

                _contexto.SaveChanges();
            }

        }

        public void AtualizarEstado(string identificador, EstadoMesa estado, ref BD.BancoContext contexto)
        {
            
            var mesa = contexto.AGBO_TMESA.FirstOrDefault(m => m.ID_MESA == identificador && m.BOL_ATIVO);

            if (mesa != null)
            {
                mesa.COD_ESTADO = estado.RecuperarValor();
                mesa.DTH_REGISTRO = DateTime.Now;

               contexto.SaveChanges();
            }

        }

        public Mesa Buscar(string identificador)
        {
            if (!string.IsNullOrEmpty(identificador))
            {
                var mesa = (from BD.Models.AGBO_TMESA m in _contexto.AGBO_TMESA
                            where m.ID_MESA == identificador && m.BOL_ATIVO
                            select new Mesa()
                            {
                                identificador = m.ID_MESA,
                                codigo = m.COD_MESA,
                                codigoEstado = m.COD_ESTADO,
                                ativo = m.BOL_ATIVO
                            }).FirstOrDefault();
              
                return mesa;
            }

            return new Mesa();
        }

        public bool MesaDisponivel(string identificador)
        {
            var disponivel = (from BD.Models.AGBO_TMESA m in _contexto.AGBO_TMESA
                              where m.ID_MESA == identificador && m.BOL_ATIVO && m.COD_ESTADO == Enumeradores.EstadoMesa.Livre.RecuperarValor()
                              select m).Count();

            return Convert.ToBoolean(disponivel);
        }
    }
}
