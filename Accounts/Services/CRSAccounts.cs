using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Accounts.Models;

namespace Accounts.Services
{
    public class CRSAccounts : IAccount
    {
        public string IBAN => throw new NotImplementedException();

        public string OwnerIIN => throw new NotImplementedException();

        public AccountType AccountType => throw new NotImplementedException();

        public async Task<IAccount> GetByIBAN(string iban)
        {
            //TODO: Implement CRSAccounts.GetByIBAN
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<IAccount>> GetByIIN(string ownerIIN)
        {
            //TODO: Implement CRSAccounts.GetByIIN
            throw new NotImplementedException();

        }
    }
}
