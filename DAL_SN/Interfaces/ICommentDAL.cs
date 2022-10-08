using Models_SN;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_SN.Interfaces
{
    public interface ICommentDAL
    {
        void create(Comment comment);
        Comment read(string Field, string Value);
        void update(Comment comment);
        void delete(Comment comment);
    }
}
