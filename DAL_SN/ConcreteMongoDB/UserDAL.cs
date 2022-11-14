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
    public class UserDAL: IUserDAL
    {
        public void create(User user)
        { 
            Connection.userCollection.InsertOne(user);
        }
        public User read(string Field,string Value)
        {
            var filterBuilder = Builders<User>.Filter;
            var filter = filterBuilder.Eq(Field, Value);
            List<User> user = Connection.userCollection.Find(filter).ToList();
            if (user[0].Posts == null)
            {
                user[0].Posts = new List<string>();
            }
            if (user[0].Followers == null)
            {
                user[0].Followers = new List<string>();
            }
            if (user[0].Following == null)
            {
                user[0].Following = new List<string>();
            }
            return user[0];
        }
        public void update(User user)
        {
            var filter = Builders<User>.Filter.Eq(s => s.Id, user.Id);
            var result =  Connection.userCollection.ReplaceOneAsync(filter, user);
        }
        public void delete(User user)
        {
           Connection.userCollection.DeleteOne(p => p.Id == user.Id);
        }

        public List<Post> getPosts(User user, int skip, int limit)
        {
            var posts = Connection.postCollection.Find(e => user.Posts.Contains(e.Id)).SortByDescending(e => e.Date).Skip(skip).Limit(limit).ToList();
            return posts;
        }
    }
}
