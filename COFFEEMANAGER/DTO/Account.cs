using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace COFFEEMANAGER.DTO
{
    public class Account
    {
        private string type, username, password;
        public string Type
        {
            get { return type; }
            set { type = value; }
        }
        public string UserName
        {
            get { return username; }
            set { username = value; }
        }
        public string Password
        {
            get { return password; }
            set { password = value; }
        }
        public Account(string username, string type,string password)
        {
            this.Type = type;
            this.UserName = username;
            this.Password = password;
        }
        public Account(DataRow row)
        {
            this.Type = row["type"].ToString();
            this.UserName = row["username"].ToString();
            this.Password = row["password"].ToString();
        }
    }
}
