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
    public partial class AddPost : Form
    {
        IPostDAL postDAL;
        IUserDAL userDAL;
        User user;
        public AddPost(User user)
        {
            postDAL = new PostDAL();
            userDAL = new UserDAL();
            this.user = user;
            InitializeComponent();
        }

        private void buttonPublishPost_Click(object sender, EventArgs e)
        {
            List<string> category = textBoxCategory.Text.Split(',').ToList();
            Author author = new Author() { Id = user.Id, FirstName = user.FirstName, LastName = user.LastName };
            Post newPost = new Post() { Title = textBoxTitle.Text, Category = category, Body = textBoxBody.Text, Authorp = author, Date = DateTime.Now };
            newPost.Comments = new List<string>();
            newPost.Likes = new List<string>();
            postDAL.create(newPost);
            user.Posts.Add(newPost.Id);
            userDAL.update(user);
            textBoxTitle.Clear();
            textBoxCategory.Clear();
            textBoxBody.Clear();
            this.Close();
        }
    }
}
