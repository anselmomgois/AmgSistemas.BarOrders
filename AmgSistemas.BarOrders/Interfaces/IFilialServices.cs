﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AmgSistemas.BarOrders.Interfaces
{
   public interface IFilialServices:IGeneric
    {
        Models.Filial Buscar(string identificador);
    }
}
