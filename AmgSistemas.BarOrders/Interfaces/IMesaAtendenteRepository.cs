using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AmgSistemas.BarOrders.Interfaces
{
    public interface IMesaAtendenteRepository : IGeneric
    {
        List<Models.MesaAtendente> Buscar(string identificadorMesa);

        string GerarAtendimento(string identificadorFuncionario, string identificadorMesa, string codigoChaveAcesso, string identificadorFilial, ref BD.BancoContext contexto);

        string GerarChaveAcesso();
    }
}
