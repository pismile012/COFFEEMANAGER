using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using COFFEEMANAGER.DAO;
using COFFEEMANAGER.DTO;
namespace COFFEEMANAGER.BUS
{
    public class AccountBUS
    {
        private static AccountBUS instance;
        public static AccountBUS Instance
        {
            get { if (instance == null) instance = new AccountBUS();return instance; }
            private set { instance = value; }
        }
        public DataTable LoadAccount()
        {
            AccountDAO dao = new AccountDAO();
            return dao.LoadAccount();
        }
        public bool Login(string username,string password)
        {
            AccountDAO dao = new AccountDAO();
            return dao.Login(username, password);
        }
        public Account GetAccountByUserName(String username)
        {
            AccountDAO dao = new AccountDAO();

            return null;
        }
        public bool AddAccount(string username, string password, string type)
        {
            AccountDAO dao = new AccountDAO();
            return dao.AddAccount(username, password, type);
        }
        public bool DelAccount(string username)
        {
            AccountDAO dao = new AccountDAO();
            return dao.DelAccount(username);
        }
        public bool UpAccount(string username, string password, string type)
        {
            AccountDAO dao = new AccountDAO();
            return dao.UpAccount(username,password,type);
        }
    }
}
