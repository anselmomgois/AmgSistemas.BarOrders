using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AmgSistemas.BarOrders.Execao
{
    public class ExecaoNegocio : Exception
    {

        private readonly Enumeradores.CodigosErros _codigo;
        private readonly string _descricao;

        public ExecaoNegocio(Enumeradores.CodigosErros codigo, string descricao)
        {
            _codigo = codigo;
            _descricao = descricao;
        }

        public Enumeradores.CodigosErros codigo
        {
            get
            {
                return _codigo;
            }
        }

        public string descricao
        {
            get
            {
                return _descricao;
            }
        }
    }
}
