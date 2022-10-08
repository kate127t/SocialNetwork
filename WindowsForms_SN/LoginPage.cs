using DAL_SN.Concrete;
using DAL_SN.Interfaces;
using Models_SN;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms_SN
{
    public partial class LoginPage : Form
    {
        IUserDAL user_dal = new UserDAL();
        public LoginPage()
        {
            InitializeComponent();
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            string login = TextLogin.Text;
            GoToMainPage(login);
        }

        private void buttonCreateNewAccount_Click(object sender, EventArgs e)
        {
            CreateNewAccount fCNA = new CreateNewAccount();
            fCNA.ShowDialog();
        }

        private void GoToMainPage(string login)
        {
            User user = user_dal.read("email", login);

            MainPage mp = new MainPage(user);
            this.Hide();
            mp.Show();
            mp.Focus();
            mp.FormClosed += (s, args) => this.Close();
        }
    }
}
