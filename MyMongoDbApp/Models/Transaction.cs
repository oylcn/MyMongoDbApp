using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace MyMongoDbApp.Models
{
    public class Transaction
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public ObjectId Id { get; set; }
        public long PolicyNo { get; set; }
        public int RenewalNo { get; set; }
        public int EndorsNo { get; set; }
        public int ChannelNo { get; set; }
        public string Message { get; set; }

    }
}
