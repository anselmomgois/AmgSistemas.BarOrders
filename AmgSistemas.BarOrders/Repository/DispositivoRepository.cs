using AmgSistemas.BarOrders.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AmgSistemas.BarOrders.Repository
{
    public class DispositivoRepository : Interfaces.IDispositivoRepository
    {

        private readonly BD.BancoContext _contexto;

        public DispositivoRepository(BD.BancoContext contexto)
        {
            _contexto = contexto;
        }

        public List<Dispositivo> Buscar(string identificadorMesaAtendente)
        {

            if (!string.IsNullOrEmpty(identificadorMesaAtendente))
            {
                return (from BD.Models.AGBO_TDISPOSITIVO di in _contexto.AGBO_TDISPOSITIVO
                        where di.ID_MESA_ATENDENTE == identificadorMesaAtendente
                        select new Dispositivo
                        {
                            codigo = di.COD_DISPOSITIVO,
                            identificador = di.ID_DISPOSITIVO,
                            data = di.DTH_DISPOSITIVO
                        }).ToList();
            }

            return null;
        }

        public void Registrar(string identificadorMesaAtendente, string codigoDispositivo)
        {
            _contexto.AGBO_TDISPOSITIVO.Add(new BD.Models.AGBO_TDISPOSITIVO
            {
                ID_DISPOSITIVO = Guid.NewGuid().ToString(),
                DTH_DISPOSITIVO = DateTime.Now,
                COD_DISPOSITIVO = codigoDispositivo,
                ID_MESA_ATENDENTE = identificadorMesaAtendente
            });

            _contexto.SaveChanges();
        }
    }
}
