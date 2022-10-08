using Models_SN;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_SN.Interfaces
{
    public interface IUserDAL
    {
        void create(User user);
        User read(string Field, string Value);
        void update(User user);
        void delete(User user);
        List<Post> getPosts(User user, int skip, int limit);
    }
}
