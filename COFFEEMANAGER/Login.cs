using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using COFFEEMANAGER.DAO;
using COFFEEMANAGER.BUS;
using COFFEEMANAGER.DTO;

namespace COFFEEMANAGER
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        bool GetType(string username)
        {
            return AccountDAO.Instance.GetTypeAccount(username);
        }
        bool login(string username,string password)
        {
            return AccountDAO.Instance.Login(username, password);
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            
            string userName = txbUserName.Text;
            string passWord = txbPassWord.Text;
            if (login(userName, passWord))
            {
                /*Account loginaccount = AccountDAO.Instance.GetAccountByUserName(userName);
                Manager fr = new Manager(loginaccount);
                this.Hide();
                fr.ShowDialog();
                this.Show();*/
                if (GetType(userName))
                {
                    MessageBox.Show("Ban dang dang nhap voi quyen admin");
                    this.Hide();
                    Manager fr = new Manager();

                    fr.ShowDialog();

                }
                else
                {
                    MessageBox.Show("Ban dang dang nhap voi quyen nhan vien");
                }

            }
            else
            {
                MessageBox.Show("Sai ten tk");
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có thật sự muốn thoát chương trình?", "Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }
    }
}
