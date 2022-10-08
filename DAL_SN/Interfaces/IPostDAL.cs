using Models_SN;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_SN.Interfaces
{
    public interface IPostDAL
    {
        void create(Post post);
        Post read(string Field, string Value);
        void update(Post post);
        void delete(Post post);
        List<Post> readManyByDate(int skip,int limit);
        List<Comment> getComments(Post post, int skip, int limit);
        List<Like> getLikes(Post post, int skip, int limit);
        bool UserLikedPost(Post post, User user);
    }
}
