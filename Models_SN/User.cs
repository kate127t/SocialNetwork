using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models_SN
{
    public class User
    {
        [BsonId]
        [BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]
        public string Id { get; set; }

        [BsonElement("email")]
        public string Email { get; set; }

        [BsonElement("password")]
        public string Password { get; set; }

        [BsonElement("firstName")]
        public string FirstName { get; set; }

        [BsonElement("lastName")]
        public string LastName { get; set; }

        [BsonElement("interests")]
        public List<string> Interests { get; set; }

        [BsonElement("followers")]
        public List<string> Followers { get; set; }

        [BsonElement("following")]
        public List<string> Following { get; set; }
        
        [BsonElement("posts")]
        public List<string> Posts { get; set; }

        public int followersCounter()
        {
            return Followers.Count;
        }

        public int followingCounter()
        {
            return Following.Count;
        }
    }
}

