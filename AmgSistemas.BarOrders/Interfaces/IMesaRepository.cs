﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AmgSistemas.BarOrders.Interfaces
{
   public  interface IMesaRepository : IGeneric
    {
        Models.Mesa Buscar(string identificador);
    }
}
