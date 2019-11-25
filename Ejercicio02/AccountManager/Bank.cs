﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ejercicio02.AccountManager.DAL.EntityFramework;
using Ejercicio02.AccountManager.DAL;
using Ejercicio02.AccountManager.Domain;

namespace Ejercicio02.AccountManager
{
    //Controlador de fachada
    public class Bank
    {
        //Metodos
        /// <summary>
        /// Retorna una lista de cuentas de un cliente
        /// </summary>
        /// <param name="pClientId"></param>
        /// <returns></returns>
        public IEnumerable<IO.AccountDTO> GetClientAccounts(int pClientId)
        {
            IList<IO.AccountDTO> accountsDTO;
            using (var bDbContext = new AccountManagerDbContext())
            {
                using (IUnitOfWork bUoW = new UnitOfWork(bDbContext))
                {
                    var bClient = bUoW.ClientRepository.Get(pClientId);

                    if (bClient != null && bClient.Accounts.Count > 0)
                    {
                        accountsDTO = new List<IO.AccountDTO>(bClient.Accounts.Count);
                        foreach (var bAccount in bClient.Accounts)
                        {
                            accountsDTO.Add(new IO.AccountDTO
                            {
                                Id = bAccount.Id,
                                Name = bAccount.Name,
                                OverDraftLimit = bAccount.OverdraftLimit,
                                Balance = bAccount.GetBalance()
                            });
                        }
                    }
                    else
                    {
                        accountsDTO = new List<IO.AccountDTO>();
                    }
                }
            }
            return accountsDTO;
        }
        /// <summary>
        /// retorna una lista de los movimientos de una cuenta
        /// </summary>
        /// <param name="pAccountId"></param>
        /// <returns></returns>
        public IEnumerable<IO.AccountMovementDTO> GetAccountMovements(int pAccountId)
        {
            IList<IO.AccountMovementDTO> accountMovementsDTO;
            using (var bDbContext = new AccountManagerDbContext())
            {
                using (IUnitOfWork bUoW = new UnitOfWork(bDbContext))
                {
                    var bAccount = bUoW.AccountRepository.Get(pAccountId);

                    if (bAccount != null && bAccount.Movements.Count > 0)
                    {
                        accountMovementsDTO = new List<IO.AccountMovementDTO>(bAccount.Movements.Count);
                        foreach (var bMovements in bAccount.Movements)
                        {
                            accountMovementsDTO.Add(new IO.AccountMovementDTO
                            {
                                Id = bMovements.Id,
                                Date = bMovements.Date,
                                Description = bMovements.Description,
                                Amount = bMovements.Amount
                            });
                        }
                    }
                    else
                    {
                        accountMovementsDTO = new List<IO.AccountMovementDTO>();
                    }
                }
            }
            return accountMovementsDTO;
        }
        /// <summary>
        /// Retorna una lsta de cuentas con saldo negativo
        /// </summary>
        /// <returns></returns>
        public IEnumerable<IO.AccountDTO> GetAccountsNegativeAMount()
        {
            IList<IO.AccountDTO> bAccountsDTO = new List<IO.AccountDTO>();
            using (var bDbContext= new AccountManagerDbContext())
            {
                using(IUnitOfWork bUoW=new UnitOfWork(bDbContext))
                {
                    var bAccounts = bUoW.AccountRepository.GetAll();
                    foreach(Account bAccount in bAccounts)
                    {
                        if (bAccount.GetBalance()<0)
                        {
                            bAccountsDTO.Add(new IO.AccountDTO
                            {
                                Id = bAccount.Id,
                                Name = bAccount.Name,
                                OverDraftLimit = bAccount.OverdraftLimit,
                                Balance = bAccount.GetBalance()
                            });
                        }
                    }
                }
            }
            return bAccountsDTO;
        }
        /// <summary>
        /// Se agrega una nueva cuenta a un cliente
        /// </summary>
        /// <param name="pIdCliente"></param>
        /// <param name="pName"></param>
        /// <param name="pOverdraftLimit"></param>
        public void NewAccount(int pClientId, String pName, int pOverdraftLimit )
        {
            using (var bDbContext = new AccountManagerDbContext())
            {
                using (IUnitOfWork bUoW = new UnitOfWork(bDbContext))
                {
                    var bClient = bUoW.ClientRepository.Get(pClientId);
                    if (bClient != null)
                    {
                        Account bAccount = new Account
                        {
                            Name = pName,
                            OverdraftLimit = pOverdraftLimit
                        };
                        bDbContext.Accounts.Add(bAccount);
                        bDbContext.SaveChanges();
                    }
                }
            }
        }
        /// <summary>
        /// Se agrega un nuevo movimiento de una cuenta
        /// </summary>
        /// <param name="pAccountId"></param>
        /// <param name="pDescription"></param>
        /// <param name="pAmount"></param>
        public void NewAccountMovement(int pAccountId, String pDescription, double pAmount )
        {
            using (var bDbContext= new AccountManagerDbContext())
            {
                using(IUnitOfWork bUoW=new UnitOfWork(bDbContext))
                {
                    var bAccount = bUoW.AccountRepository.Get(pAccountId);
                    if(bAccount!=null)
                    {
                        AccountMovement pAccountM = new AccountMovement
                        {
                            Date=DateTime.Today,
                            Description=pDescription,
                            Amount=pAmount
                        };
                        bAccount.Movements.Add(pAccountM);
                        bDbContext.SaveChanges();
                    }
                }
            }
        }
    }
}
