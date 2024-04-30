using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using System;

namespace BooksContent.Models
{
    public class Book
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public ObjectId Id { get; set; }

        public string Titulo { get; set; }
        public string? Id_Autor { get; set; }
        public string Description { get; set; }
        public DateTime fechaInicio { get; set; }
        
        //public List<Capitulo> Capitulos { get; set; }
    }
}
