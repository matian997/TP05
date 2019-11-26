using System;
using System.Collections.Generic;
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
        /// Retorna una lista de cuentas con saldo negativo
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
                        if (bAccount != null)
                        {
                            if (bAccount.GetBalance() > Convert.ToDouble(bAccount.OverdraftLimit))
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
            }
            return bAccountsDTO;
        }
        /// <summary>
        /// Se agrega una nueva cuenta a un cliente
        /// </summary>
        /// <param name="pIdCliente"></param>
        /// <param name="pName"></param>
        /// <param name="pOverdraftLimit"></param>
        public bool NewAccount(int pClientId, String pName, int pOverdraftLimit )
        {
            bool agregado = false;
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
                        bClient.Accounts.Add(bAccount);
                        bDbContext.Accounts.Add(bAccount);
                        bDbContext.SaveChanges();
                        agregado = true;
                    }
                }
            }
            return agregado;
        }
        /// <summary>
        /// Se agrega un nuevo movimiento de una cuenta
        /// </summary>
        /// <param name="pAccountId"></param>
        /// <param name="pDescription"></param>
        /// <param name="pAmount"></param>
        public bool NewAccountMovement(int pAccountId, String pDescription, double pAmount, DateTime pDate)
        {
            bool agregado = false;
            using (var bDbContext= new AccountManagerDbContext())
            {
                using(IUnitOfWork bUoW=new UnitOfWork(bDbContext))
                {
                    var bAccount = bUoW.AccountRepository.Get(pAccountId);
                    if(bAccount!=null)
                    {
                        AccountMovement pAccountM = new AccountMovement
                        {
                            Date=pDate,
                            Description=pDescription,
                            Amount=pAmount
                        };
                       
                        bAccount.Movements.Add(pAccountM);
                        bDbContext.AccountMovements.Add(pAccountM);
                        bDbContext.SaveChanges();
                        agregado = true;
                    }
                }
            }
            return agregado; 
        }
    }
}

