using System.Collections.Generic;
using System.Threading.Tasks;
using Accounts.Models;

namespace Accounts.Services
{
    public interface IAccounts
    {
        Task<IAccount> GetByIBAN(string iban);
        Task<IEnumerable<IAccount>> GetByIIN(string ownerIIN);
    }
}