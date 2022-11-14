using Models_SN;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_SN.Concrete
{
    static class Connection
    {
        public static string ConnectionString = "mongodb://localhost:27017/";
        public static MongoClient client = new MongoClient(ConnectionString);
        public static IMongoDatabase database = client.GetDatabase("SocialNetwork");
        public static IMongoCollection<User> userCollection = Connection.database.GetCollection<User>("users");
        public static IMongoCollection<Post> postCollection = Connection.database.GetCollection<Post>("posts");
        public static IMongoCollection<Comment> commentCollection = Connection.database.GetCollection<Comment>("comments");
        public static IMongoCollection<Like> likeCollection = Connection.database.GetCollection<Like>("likes");
    }
}
