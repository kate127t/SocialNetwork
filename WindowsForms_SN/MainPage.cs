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
    public partial class MainPage : Form
    {
        User user;
        IUserDAL userDAL;
        IPostDAL postDAL;
        public MainPage(User user)
        {
            this.user = user;
            this.userDAL = new UserDAL();
            this.postDAL = new PostDAL();
            //PostUC postUC = new PostUC();
            InitializeComponent();
        }

        private void MainPage_Load(object sender, EventArgs e)
        {
            labelUserName.Text = user.FirstName + " " + user.LastName;
            labelFollowers.Text = user.followersCounter().ToString() + " " + "Followers";
            labelFollowing.Text = user.followingCounter().ToString() + " " + "Following";
            string interests = "Interests:\n";
            for(int i = 0; i < user.Interests.Count; i++)
            {
                interests += "- " + user.Interests[i] + "\n";
            }
            labelInterests.Text = interests;
            ShowRecentPosts();

        }

        private void buttonWritePost_Click(object sender, EventArgs e)
        {
            AddPost fAddPost = new AddPost(user);
            fAddPost.ShowDialog();
            ShowRecentPosts();
        }

        private void ShowRecentPosts()
        {
            //ScrollBar vScrollBar1 = new VScrollBar();
            //vScrollBar1.Dock = DockStyle.Right;
            //vScrollBar1.Scroll += (sender, e) => { tableLayoutPanelRecentPosts.VerticalScroll.Value = vScrollBar1.Value; };
            //tableLayoutPanelRecentPosts.Controls.Add(vScrollBar1);
            //vScrollBar1.
            while (tableLayoutPanelRecentPosts.Controls.Count > 0)
            {
                tableLayoutPanelRecentPosts.Controls[0].Dispose();
            }
            List<Post> recent_posts = postDAL.readManyByDate(0, 10);
            List<PostUC> postUCs = new List<PostUC>();
            for (int i = 0; i < recent_posts.Count; i++)
            {
                Console.WriteLine(i);
                postUCs.Add(new PostUC(recent_posts[i], user));
                //tableLayoutPanelRecentPosts.
                tableLayoutPanelRecentPosts.Controls.Add(postUCs[i]);
            }
        }


        private void buttonSearchPerson_Click(object sender, EventArgs e)
        {
            User viewUser = userDAL.read("email", textBoxSearch.Text);
            ViewPerson vp = new ViewPerson(user, viewUser);
            vp.ShowDialog();
            vp.FormClosed += (s, args) => this.labelFollowing.Text = user.followingCounter().ToString() + " " + "Following";
        }
    }
}
