using AmgSistemas.BarOrders.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AmgSistemas.BarOrders.Repository
{
    public class FilialRepository : Interfaces.IFilialRepository
    {
        private readonly BD.BancoContext _contexto;

        public FilialRepository(BD.BancoContext contexto)
        {
            _contexto = contexto;
        }

        public Filial Buscar(string identificador)
        {
            if (!string.IsNullOrEmpty(identificador))
            {
             
                return (from BD.Models.AGBO_TFILIAL f in _contexto.AGBO_TFILIAL
                        join BD.Models.AGBO_TEMPRESA e in _contexto.AGBO_TEMPRESA on f.ID_EMPRESA equals e.ID_EMPRESA
                        where f.ID_FILIAL == identificador
                        select new Models.Filial()
                        {
                            identificador = f.ID_FILIAL,
                            codigo = f.COD_FILIAL,
                            descricao = f.DES_FILIAL,
                            solicitarTelefone = f.BOL_SOLICITAR_TELEFONE,
                            trabalhaPorMesa = f.BOL_TRABALHA_POR_MESA,
                            empresa = new Empresa()
                            {
                                codigo = e.COD_EMPRESA,
                                descricao = e.DES_EMPRESA,
                                identificador = e.ID_EMPRESA,
                                logo = e.BOL_IMAGEM

                            }
                        }).FirstOrDefault();
            }

            return new Filial();
        }
    }
}
