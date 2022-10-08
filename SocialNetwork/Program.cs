using DAL_SN.Concrete;
using DAL_SN.Interfaces;
using Models_SN;
using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialNetwork
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string ConnectionString = "mongodb://localhost:27017/";
            //var client = new MongoClient(ConnectionString);
            //var database = client.GetDatabase("SocialNetwork");
            //IMongoCollection<BsonDocument> userBsonCollection = database.GetCollection<BsonDocument>("users");

            ////var filterBuilder = Builders<BsonDocument>.Filter;
            ////var filter = filterBuilder.Eq("email", "IslaTorres@gmail.com");
            ////var userBson = userBsonCollection.Find(filter).ToString();

            //try {
            //    var filterBuilder = Builders<BsonDocument>.Filter;
            //    var filter = filterBuilder.Eq("email", "IslaTorres@gmail.com");
            //    var userBson = userBsonCollection.Find(filter).ToList();
            //    Console.WriteLine(userBson);
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}

            IUserDAL user_dal = new UserDAL();
            IPostDAL post_dal = new PostDAL();
            //User user = new User();
            //user.FirstName = "Tina";
            //user.LastName = "Brown";

          


            try
            {
                User user = user_dal.read("email", "SophiaJohnson@gmail.com");
                Post post = post_dal.read("title","Italy");
                bool liked = post_dal.UserLikedPost(post,user);
                Console.WriteLine(liked);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            //Console.WriteLine(user.FirstName + "    "+ user.LastName);
            Console.ReadKey();
        }

       
    }
}
