using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models_SN
{
    public class Comment
    {
        [BsonId]
        [BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]
        public string Id { get; set; }

        [BsonElement("author")]
        public Author Authorc { get; set; }

        [BsonElement("body")]
        public string Body { get; set; }

        [BsonElement("date")]
        public DateTime Date { get; set; }
    }
}
