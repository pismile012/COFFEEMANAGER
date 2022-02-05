using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Security.Cryptography;
using COFFEEMANAGER.DTO;

namespace COFFEEMANAGER.DAO
{
    public class AccountDAO
    {
        private static AccountDAO instance;

        public static AccountDAO Instance
        {
            get { if (instance == null) instance = new AccountDAO(); return instance; }
            private set { instance = value; }
        }
        public DataTable LoadAccount()
        {
            Provider p = new Provider();
            DataTable dt = null;
            try
            {
                string strSql = "sp_LoadAccount";
                p.Connect();
                dt = p.ExcecuteQuery(CommandType.StoredProcedure, strSql);
            }
            catch(Exception ex)
            {
                throw ex;
            }
            finally
            {
                p.DisConnect();
            }
            return dt;
        }
        public bool Login(string username, string password)
        {
            byte[] temp = ASCIIEncoding.ASCII.GetBytes(password);
            byte[] hasData = new MD5CryptoServiceProvider().ComputeHash(temp);

            string hasPass = "";
            
            Provider p = new Provider();
            DataTable dt = null;
            foreach (byte item in hasData)
            {
                hasPass += item;
            }
            try
            {
                string strSql = "USP_Login";
                p.Connect();
                dt = p.ExcecuteQuery(CommandType.StoredProcedure, strSql,
                    new SqlParameter {ParameterName ="@userName",Value = username },
                    new SqlParameter { ParameterName = "@passWord", Value = hasPass });
            }
            catch(Exception ex)
            {
                throw ex;
            }
            finally
            {
                p.DisConnect();
            }
            return dt.Rows.Count > 0;
        }
        public Account GetAccountByUserName(String username)
        {
            Provider p = new Provider();
            try
            {
                string strSql = "sp_GetAccountByUserName";
                p.Connect();
                DataTable dt = p.ExcecuteQuery(CommandType.StoredProcedure, strSql,
                    new SqlParameter { ParameterName = "username", Value = username });
                foreach (DataRow item in dt.Rows)
                {
                    return new Account(item);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                p.DisConnect();
            }
            return null;
        }
        public bool GetTypeAccount(string username)
        {
            Provider p = new Provider();
            DataTable dt = null;
            try
            {
                string strSql = "sp_GetTypeAccount";
                p.Connect();
                dt = p.ExcecuteQuery(CommandType.StoredProcedure, strSql,
                    new SqlParameter { ParameterName = "@username", Value = username });
                if (dt.Rows[0][0].ToString() == "admin")
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                p.DisConnect();
            }
        }
        public bool AddAccount(string username, string password, string type)
        {
            byte[] temp = ASCIIEncoding.ASCII.GetBytes(password);
            byte[] hasData = new MD5CryptoServiceProvider().ComputeHash(temp);

            string hasPass = "";
            Provider p = new Provider();
            int nRow = 0;
            foreach (byte item in hasData)
            {
                hasPass += item;
            }
            try
            {
                string strSql = "sp_AddAccount";
                p.Connect();
                nRow = p.ExcecuteNonQuery(CommandType.StoredProcedure, strSql,
                    new SqlParameter { ParameterName = "@username", Value = username },
                    new SqlParameter { ParameterName = "@password", Value = hasPass },
                    new SqlParameter { ParameterName = "@type", Value = type });
            }
            catch(Exception ex)
            {
                throw ex;
            }
            finally
            {
                p.DisConnect();
            }
            return nRow > 0;
        }
        public bool DelAccount(string username)
        {
            Provider p = new Provider();
            int nRow = 0;
            try
            {
                string strSql = "sp_DelAccount";
                p.Connect();
                nRow = p.ExcecuteNonQuery(CommandType.StoredProcedure, strSql,
                    new SqlParameter { ParameterName = "@username", Value = username });
            }
            catch(Exception ex)
            {
                throw ex;
            }
            finally
            {
                p.DisConnect();
            }
            return nRow > 0;
        }
        public bool UpAccount(string username, string password, string type)
        {
            byte[] temp = ASCIIEncoding.ASCII.GetBytes(password);
            byte[] hasData = new MD5CryptoServiceProvider().ComputeHash(temp);

            string hasPass = "";
            Provider p = new Provider();
            int nRow = 0;
            foreach (byte item in hasData)
            {
                hasPass += item;
            }
            try
            {
                string strSql = "sp_UpAccount";
                p.Connect();
                nRow = p.ExcecuteNonQuery(CommandType.StoredProcedure, strSql,
                    new SqlParameter { ParameterName = "@username", Value = username },
                    new SqlParameter { ParameterName = "@password", Value = hasPass },
                    new SqlParameter { ParameterName = "@type", Value = type });
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                p.DisConnect();
            }
            return nRow > 0;
        }
    }
}
