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
    public partial class ViewPerson : Form
    {
        IUserDAL userDAL = new UserDAL();
        IPostDAL postDAL = new PostDAL();
        UsersBLL usersBLL = new UsersBLL();
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

            RefreshRelationshipLabels();
            
            string interests = "Interests:\n";
            for (int i = 0; i < viewUser.Interests.Count; i++)
            {
                interests += "- " + viewUser.Interests[i] + "\n";
            }
            labelInterests.Text = interests;
            tableLayoutPanelRecentPosts.Visible = true;

            ShowRecentPosts();
        }

        private void RefreshRelationshipLabels()
        {
            int followersCounter = usersBLL.countFollowers(viewUser);
            int followingCounter = usersBLL.countFollows(viewUser);
            int shortestPath = usersBLL.countShortestPath(curUser, viewUser);
            bool follows = usersBLL.CheckIfFollows(curUser, viewUser);

            labelFollowers.Text = followersCounter.ToString() + " " + "Followers";
            labelFollowing.Text = followingCounter.ToString() + " " + "Following";
            labelShortestPath.Text = "Shortest path: " + shortestPath.ToString();

            if (follows)
            {
                buttonFollow.Text = "Unfollow";
            }
            else
            {
                buttonFollow.Text = "Follow";
            }
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
            bool follows = usersBLL.CheckIfFollows(curUser, viewUser);

            if (follows)
            {
                usersBLL.unfollow(curUser, viewUser);
            }
            else
            {
                usersBLL.follow(curUser, viewUser);
            }
            RefreshRelationshipLabels();
        }
    }
}
