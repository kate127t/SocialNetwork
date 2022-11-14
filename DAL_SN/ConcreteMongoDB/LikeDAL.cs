using DAL_SN.Interfaces;
using Models_SN;
using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_SN.Concrete
{
    public class LikeDAL : ILikeDAL
    {
        public void create(Like like)
        {
            Connection.likeCollection.InsertOne(like);
        }

        public void delete(Like like)
        {
            Connection.likeCollection.DeleteOne(p => p.Id == like.Id);
        }

        public Like read(string Field, string Value)
        {
            var filterBuilder = Builders<Like>.Filter;
            var filter = filterBuilder.Eq(Field, Value);
            List<Like> like = Connection.likeCollection.Find(filter).ToList();
            return like[0];
        }

        public Like read(string Field, ObjectId Value)
        {
            var filterBuilder = Builders<Like>.Filter;
            var filter = filterBuilder.Eq(Field, Value);
            List<Like> like = Connection.likeCollection.Find(filter).ToList();
            return like[0];
        }
        public void update(Like like)
        {
            var filter = Builders<Like>.Filter.Eq(s => s.Id, like.Id);
            var result = Connection.likeCollection.ReplaceOneAsync(filter, like);
        }
    }
}
