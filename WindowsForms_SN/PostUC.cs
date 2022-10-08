using DAL_SN.Concrete;
using DAL_SN.Interfaces;
using Models_SN;
using MongoDB.Bson;
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
    public partial class PostUC : UserControl
    {
        Post post;
        User cur_user;
        ILikeDAL likeDAL;
        ICommentDAL commentDAL;
        IPostDAL postDAL;
        public PostUC(Post post,User cur_user)
        {
            InitializeComponent();
            this.post = post;
            this.cur_user = cur_user;
            likeDAL = new LikeDAL();
            commentDAL = new CommentDAL();
            postDAL = new PostDAL();
        }

        private void PostUC_Load(object sender, EventArgs e)
        {
            labelTitle.Text = post.Title;
            labelAuthor.Text = post.Authorp.FirstName + " " + post.Authorp.LastName;
            string cat = "";
            if (post.Category != null)
            {
                for (int i = 0; i<post.Category.Count; i++)
                {
                    cat += post.Category[i];
                    if (i != post.Category.Count-1)
                    {
                        cat += ", ";
                    }
                }
                labelCategory.Text = cat;
            }
            labelBody.Text = post.Body;
            checkBoxLikes.Text = post.likeCounter().ToString() + " Likes";
            if (postDAL.UserLikedPost(post,cur_user))
            {
                checkBoxLikes.Checked = true;
            }
            LabelCommentNumber.Text = post.commentCounter().ToString() + " Comments";
        }

        private void buttonShowLikes_Click(object sender, EventArgs e)
        {
            //Displays 10 most recent users, who liked the post.
            string textLikes = "";
            List<Like> likes= postDAL.getLikes(post, 0, 10);
            for(int i = 0; i<likes.Count; i++)
            {
                textLikes += likes[i].Authorl.FirstName + " " + likes[i].Authorl.LastName+"\n";
            }
            MessageBox.Show(textLikes);
        }

        private void buttonAddComment_Click(object sender, EventArgs e)
        {
            AddComment fAddComment = new AddComment(post, cur_user);
            fAddComment.ShowDialog();
            LabelCommentNumber.Text = post.commentCounter().ToString() + " Comments";
        }

        private void buttonShowComments_Click(object sender, EventArgs e)
        {
            //Displays 10 most recent comments to the post.
            string textComments = "";
            List<Comment> comments = postDAL.getComments(post,0,10);
            for (int i = 0; i<comments.Count; i++)
            {
                textComments += comments[i].Authorc.FirstName + " " + comments[i].Authorc.LastName+": " + comments[i].Body + '\n';
            }
            MessageBox.Show(textComments);
        }

        private void checkBoxLikes_CheckedChanged(object sender, EventArgs e)
        {
            // If checked == true add new like to post, else delete like
            if (checkBoxLikes.Checked)
            {
                Author author = new Author() { FirstName = cur_user.FirstName, LastName = cur_user.LastName, Id = cur_user.Id };
                Like like = new Like() { Authorl = author , Date = DateTime.Now};
                likeDAL.create(like);
                post.Likes.Add(like.Id);
                postDAL.update(post);
                checkBoxLikes.Text = post.likeCounter().ToString() + " Likes";
            }
            else
            {
                Like like = likeDAL.read("author._id",ObjectId.Parse(cur_user.Id));
                post.Likes.Remove(like.Id);
                postDAL.update(post);
                likeDAL.delete(like);
                checkBoxLikes.Text = post.likeCounter().ToString() + " Likes";
            }
        }
    }
}
