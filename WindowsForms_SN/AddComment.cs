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
    public partial class AddComment : Form
    {
        Post post;
        User user;
        ICommentDAL commentDAL;
        IPostDAL postDAL;
        public AddComment(Post post, User user)
        {
            this.post = post;
            this.user = user;
            this.commentDAL = new CommentDAL();
            this.postDAL = new PostDAL();
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Author author = new Author() { FirstName = user.FirstName, LastName = user.LastName, Id = user.Id };
            Comment comment = new Comment() { Authorc = author, Date = DateTime.Now ,Body = textBoxCommentBody.Text};
            commentDAL.create(comment);
            post.Comments.Add(comment.Id);
            postDAL.update(post);
        }
    }
}
