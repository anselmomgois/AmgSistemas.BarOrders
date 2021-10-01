using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AmgSistemas.BarOrders.Interfaces
{
   public interface IDispositivoRepository :IGeneric
    {
        List<Models.Dispositivo> Buscar(string identificadorMesaAtendente);
        void Registrar(string identificadorMesaAtendente, string codigoDispositivo);
    }
}
