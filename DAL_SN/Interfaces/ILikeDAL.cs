using Models_SN;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_SN.Interfaces
{
    public interface ILikeDAL
    {
        void create(Like like);
        Like read(string Field, string Value);
        Like read(string Field, ObjectId Value);
        void update(Like like);
        void delete(Like like);
    }
}
