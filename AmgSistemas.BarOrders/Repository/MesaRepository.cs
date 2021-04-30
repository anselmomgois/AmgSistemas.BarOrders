using AmgSistemas.BarOrders.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AmgSistemas.BarOrders.Repository
{
    public class MesaRepository : Interfaces.IMesaRepository
    {
        public Mesa Buscar(string identificador)
        {
            if (!string.IsNullOrEmpty(identificador))
            {
                BD.BancoContext objBD = new BD.BancoContext();

                return (from BD.Models.AGBO_TMESA m in objBD.AGBO_TMESA
                        where m.ID_MESA == identificador
                        select new Mesa()
                        {
                            identificador = m.ID_MESA,
                            codigo = m.COD_MESA,
                            codigoEstado = m.COD_ESTADO,
                            ativo = m.BOL_ATIVO
                        }).FirstOrDefault();
            }

            return new Mesa();
        }
    }
}
