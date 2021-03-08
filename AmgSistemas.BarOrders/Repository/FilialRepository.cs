﻿using AmgSistemas.BarOrders.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AmgSistemas.BarOrders.Repository
{
    public class FilialRepository : Interfaces.IFilialRepository
    {
        public Filial Buscar(string identificador)
        {
            if (!string.IsNullOrEmpty(identificador))
            {
                BD.BancoContext objBD = new BD.BancoContext();

                return (from BD.Models.AGBO_TFILIAL f in objBD.AGBO_TFILIAL
                        join BD.Models.AGBO_TEMPRESA e in objBD.AGBO_TEMPRESA on f.ID_EMPRESA equals e.ID_EMPRESA
                        where f.ID_FILIAL == identificador
                        select new Models.Filial()
                        {
                            identificador = f.ID_FILIAL,
                            codigo = f.COD_FILIAL,
                            descricao = f.DES_FILIAL,
                            empresa = new Empresa()
                            {
                                codigo = e.COD_EMPRESA,
                                descricao = e.DES_EMPRESA,
                                identificador = e.ID_EMPRESA
                            }
                        }).FirstOrDefault();
            }

            return new Filial();
        }
    }
}