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
    public partial class ViewPerson : Form
    {
        IUserDAL userDAL = new UserDAL();
        IPostDAL postDAL = new PostDAL();
        User curUser;
        User viewUser;
        public ViewPerson(User curUser,User viewUser)
        {
            this.curUser = curUser;
            this.viewUser = viewUser;
            InitializeComponent();
        }

        private void ViewPerson_Load(object sender, EventArgs e)
        {
            labelUserName.Text = viewUser.FirstName + " " + viewUser.LastName;
            labelFollowers.Text = viewUser.followersCounter().ToString() + " " + "Followers";
            labelFollowing.Text = viewUser.followingCounter().ToString() + " " + "Following";
            string interests = "Interests:\n";
            for (int i = 0; i < viewUser.Interests.Count; i++)
            {
                interests += "- " + viewUser.Interests[i] + "\n";
            }
            labelInterests.Text = interests;
            tableLayoutPanelRecentPosts.Visible = true;

            if (curUser.Following.Contains(viewUser.Id))
            {
                buttonFollow.Text = "Unfollow";
            }
            else
            {
                buttonFollow.Text = "Follow";
            }
            ShowRecentPosts();
        }
        private void ShowRecentPosts()
        {
            while (tableLayoutPanelRecentPosts.Controls.Count > 0)
            {
                tableLayoutPanelRecentPosts.Controls[0].Dispose();
            }
            List<Post> recent_posts = userDAL.getPosts(viewUser,0, 10);
            List<PostUC> postUCs = new List<PostUC>();
            for (int i = 0; i < recent_posts.Count; i++)
            {
                Console.WriteLine(i);
                postUCs.Add(new PostUC(recent_posts[i], curUser));
                tableLayoutPanelRecentPosts.Controls.Add(postUCs[i]);
            }
        }

        private void buttonFollow_Click(object sender, EventArgs e)
        {
            if (curUser.Following.Contains(viewUser.Id))
            {
                curUser.Following.Remove(viewUser.Id);
                viewUser.Followers.Remove(curUser.Id);
                buttonFollow.Text = "Follow";
            }
            else
            {
                curUser.Following.Add(viewUser.Id);
                viewUser.Followers.Add(curUser.Id);
                buttonFollow.Text = "Unfollow";
            }
            userDAL.update(curUser);
            userDAL.update(viewUser);
            labelFollowers.Text = viewUser.followersCounter().ToString() + " " + "Followers";
        }
    }
}
