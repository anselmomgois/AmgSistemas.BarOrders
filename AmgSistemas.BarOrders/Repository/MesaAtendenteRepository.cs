using AmgSistemas.BarOrders.BD;
using AmgSistemas.BarOrders.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AmgSistemas.BarOrders.Repository
{
    public class MesaAtendenteRepository : Interfaces.IMesaAtendenteRepository
    {
        public List<MesaAtendente> Buscar(string identificadorMesa)
        {
            if (!string.IsNullOrEmpty(identificadorMesa))
            {
                BD.BancoContext objBD = new BD.BancoContext();

            
                var mesasAtendentes = (from BD.Models.AGBO_TMESA_ATENDENTE ma in objBD.AGBO_TMESA_ATENDENTE
                                        join BD.Models.AGBO_TFUNCIONARIO f in objBD.AGBO_TFUNCIONARIO on ma.ID_FUNCIONARIO equals f.ID_FUNCIONARIO
                                        where ma.ID_MESA == identificadorMesa && ma.BOL_CORRENTE
                                        select new MesaAtendente
                                        {
                                            dataRegistro = ma.DTH_REGISTRO,
                                            identificador = ma.ID_MESA_ATENDENTE,
                                            nomeAtendente = f.DES_NOME,
                                            codigoChaveAcesso = ma.COD_CHAVE_ACESSO,
                                            codigoComanda = ma.COD_COMANDA
                                        }).ToList();


                return mesasAtendentes;
            }

            return new List<MesaAtendente>();
        }

        public string GerarAtendimento(string identificadorFuncionario, string identificadorMesa, string codigoChaveAcesso, ref BancoContext contexto)
        {
            BD.BancoContext bdContexto = contexto;
            string identificador = Guid.NewGuid().ToString();

            bdContexto.AGBO_TMESA_ATENDENTE.Add(new BD.Models.AGBO_TMESA_ATENDENTE
            {
                BOL_CORRENTE = true,
                COD_CHAVE_ACESSO = codigoChaveAcesso,
                DTH_REGISTRO = DateTime.Now,
                ID_FUNCIONARIO = identificadorFuncionario,
                ID_MESA = identificadorMesa,
                ID_MESA_ATENDENTE = identificador
            });

            bdContexto.SaveChanges();

            return identificador;
        }

        public string GerarChaveAcesso()
        {
           
            Random chave = new Random();
            return chave.Next(000001, 999999).ToString();
        }
    }
}
