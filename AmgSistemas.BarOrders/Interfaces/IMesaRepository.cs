using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AmgSistemas.BarOrders.Interfaces
{
   public  interface IMesaRepository : IGeneric
    {
        Models.Mesa Buscar(string identificador);

        bool MesaDisponivel(string identificador);
        void AtualizarEstado(string identificador, Enumeradores.EstadoMesa estado);

        void AtualizarEstado(string identificador, Enumeradores.EstadoMesa estado, ref BD.BancoContext contexto);
    }
}
