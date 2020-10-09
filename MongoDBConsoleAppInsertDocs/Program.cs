using MongoDB.Driver;
using MongoDB.Bson;
using System;

namespace MongoDBConsoleAppInsertDocs
{
    class Program
    {
        static void Main(string[] args)
        {
            var dbClient = new MongoClient("mongodb://127.0.0.1:27017");

            IMongoDatabase db = dbClient.GetDatabase("MyDatabase");

            var cars = db.GetCollection<BsonDocument>("Person");

            var doc = new BsonDocument
            {
                {"Name", "Name05 Surname05"},
                {"SiblingCount", 0},
                {"DateOfBirth",new BsonDateTime(1987-12-11) }
            };

            cars.InsertOne(doc);

            Console.Read();
        }
    }
}