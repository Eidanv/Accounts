using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Accounts;

namespace Accounts.Models
{
    public interface IAccount
    {
        string IBAN { get; }
        string OwnerIIN { get; }
        AccountType AccountType { get; }
    }

    public enum AccountType
    {
        CardAccount,
        CurrentAccount,
        DepositAccount
    }
}