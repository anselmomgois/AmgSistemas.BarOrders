using AmgSistemas.BarOrders.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace AmgSistemas.BarOrders.Repository
{
    public class EmpresaRepository : Interfaces.IEmpresaRepository
    {

        private readonly BD.BancoContext _contexto;

        public EmpresaRepository(BD.BancoContext contexto)
        {
            _contexto = contexto;
        }

        public Empresa Buscar(string identificador)
        {

            if (!string.IsNullOrEmpty(identificador))
            {
               
                return (from BD.Models.AGBO_TEMPRESA e in _contexto.AGBO_TEMPRESA
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
