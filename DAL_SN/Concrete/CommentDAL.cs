using DAL_SN.Interfaces;
using Models_SN;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_SN.Concrete
{
    public class CommentDAL : ICommentDAL
    {
        public void create(Comment comment)
        {
            Connection.commentCollection.InsertOne(comment);
        }

        public void delete(Comment comment)
        {
            Connection.commentCollection.DeleteOne(p => p.Id == comment.Id);
        }

        public Comment read(string Field, string Value)
        {
            var filterBuilder = Builders<Comment>.Filter;
            var filter = filterBuilder.Eq(Field, Value);
            List<Comment> comment = Connection.commentCollection.Find(filter).ToList();
            return comment[0];
        }

        public void update(Comment comment)
        {
            var filter = Builders<Comment>.Filter.Eq(s => s.Id, comment.Id);
            var result = Connection.commentCollection.ReplaceOneAsync(filter, comment);
        }
    }
}
