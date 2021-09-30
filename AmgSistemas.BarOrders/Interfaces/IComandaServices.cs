using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AmgSistemas.BarOrders.Interfaces
{
    public interface IComandaServices :IGeneric
    {
        string IniciarAtendimento(string identificadorMesa, string identificadorFilial, bool trabalhaPorMesa, string identificadorFuncionario, string codPrefixoComanda, bool trabalhaComComanda);
    }
}
