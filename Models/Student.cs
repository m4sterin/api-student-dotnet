using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;

namespace api_studentManagement_dotnet.Models
{
    public class Student
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; } = String.Empty;

        [BsonElement("Name")]
        public string Name { get; set; } = String.Empty;

        [BsonElement("Gratuated")]
        public bool IsGraduated { get; set; }

        [BsonElement("Courses")]
        public string[]? Courses { get; set; }

        [BsonElement("Gender")]
        public string Gender { get; set; } = String.Empty;

        [BsonElement("Age")]
        public int Age { get; set; }
    }
}
