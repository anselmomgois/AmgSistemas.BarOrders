using AmgSistemas.BarOrders.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AmgSistemas.BarOrders.Repository
{
    public class ParametroRepository : Interfaces.IParametroRepository
    {
        private readonly BD.BancoContext _contexto;

        public ParametroRepository(BD.BancoContext contexto)
        {
            _contexto = contexto;
        }
        public List<Parametro> Buscar(string identificadorEmpresa, string identificadorFilial)
        {
            
            return (from BD.Models.AGBO_TPARAMETROS p in _contexto.AGBO_TPARAMETROS
                    select new Parametro
                    {
                        identificador = p.ID_PARAMETRO,
                        codigo = p.COD_PARAMETRO,
                        descricao = p.DES_PARAMETRO,
                        tipoParametro = Extensoes.EnumExtension.RecuperarEnum<Enumeradores.TipoParametro>(p.COD_TIPO_PARAMETRO),
                        valor = (from BD.Models.AGBO_TPARAMETRO_VALOR pv in _contexto.AGBO_TPARAMETRO_VALOR
                                 where pv.ID_PARAMETRO == p.ID_PARAMETRO && pv.ID_EMPRESA == identificadorEmpresa && 
                                       (string.IsNullOrEmpty(pv.ID_FILIAL) || (!string.IsNullOrEmpty(pv.ID_FILIAL) &&  pv.ID_FILIAL == identificadorFilial))
                                 select pv.DES_VALOR_PARAMETRO).FirstOrDefault()
                    }).ToList();
        }
    }
}
