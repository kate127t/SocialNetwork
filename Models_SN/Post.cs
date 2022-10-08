using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models_SN
{
    public class Post
    {
        [BsonId]
        [BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]
        public string Id { get; set; }

        [BsonElement("title")]
        public string Title { get; set; }

        [BsonElement("author")]
        public Author Authorp { get; set; }

        [BsonElement("category")]
        public List<string> Category { get; set; }

        [BsonElement("body")]
        public string Body { get; set; }

        [BsonElement("date")]
        public DateTime Date { get; set; }

        [BsonElement("comments")]
        public List<string> Comments { get; set; }


        [BsonElement("likes")]
        //[BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]
        public List<string> Likes { get; set; }

        public int commentCounter()
        {
            if (Comments != null)
            {
                return Comments.Count;
            }
            return 0;
        }

        public int likeCounter()
        {
            if(Likes != null)
            {
                return Likes.Count;
            }
            return 0;
        }
    }
}
