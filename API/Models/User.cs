using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Models
{
    public class User
    {
        [BsonRepresentation(BsonType.ObjectId)]
        public ObjectId _id { get; set; }
        public string UserName { get; set; }
        public string PassWord { get; set; }
        public string UserID { get; set; }
        public string AccessKey { get; set; }
    }
}
