using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class AccountService
    {
        private AccountRepository accountRepo;

        public AccountService()
        {
            accountRepo = new AccountRepository();
        }

        public bool Login(string username, string password)
        {
            return accountRepo.CheckLogin(username, password);
        }
    }
}
