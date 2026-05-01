using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class AccountRepository
    {
        private SchoolDbContext dbContext;

        public AccountRepository()
        {
            dbContext = new SchoolDbContext();
        }

        // Kiểm tra đăng nhập
        public bool CheckLogin(string username, string password)
        {
            return dbContext.Accounts.Any(a =>
                a.Username == username &&
                a.Password == password);
        }

        // (Tuỳ chọn) Lấy thông tin user sau khi login
        public Account GetAccount(string username, string password)
        {
            return dbContext.Accounts
                .FirstOrDefault(a =>
                    a.Username == username &&
                    a.Password == password);
        }

    }
}
