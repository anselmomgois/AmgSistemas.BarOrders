using AmgSistemas.BarOrders.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace AmgSistemas.BarOrders.Repository
{
    public class EmpresaRepository : Interfaces.IEmpresaRepository
    {
        public Empresa Buscar(string identificador)
        {

            if (!string.IsNullOrEmpty(identificador))
            {
                BD.BancoContext objBD = new BD.BancoContext();

                return (from BD.Models.AGBO_TEMPRESA e in objBD.AGBO_TEMPRESA
                        where e.ID_EMPRESA == identificador
                        select new Models.Empresa()
                        {
                            identificador = e.ID_EMPRESA,
                            codigo = e.COD_EMPRESA,
                            descricao = e.DES_EMPRESA
                        }).FirstOrDefault();
            }

            return new Empresa();
        }
    }
}
