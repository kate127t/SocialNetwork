using BLL_SN;
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
    public partial class CreateNewAccount : Form
    {
        IUserDAL userDAL = new UserDAL();
        UsersBLL usersBLL = new UsersBLL();
        public CreateNewAccount()
        {
            InitializeComponent();
        }

        private void buttonCreateAccount_Click(object sender, EventArgs e)
        {
            User user = new User();
            user.Email = textBoxEmail.Text;
            user.Password = textBoxPassword.Text;
            user.FirstName = textBoxFirstName.Text;
            user.LastName = textBoxLastName.Text;
            user.Interests = textBoxInterests.Text.Split(',').ToList();
            user.Followers = new List<string>();
            user.Following = new List<string>();
            user.Posts = new List<string>();

            usersBLL.create(user);

            this.Close();
        }
    }
}
