using System;
using MongoDB.Bson;
using NUnit.Framework;

namespace Tests
{   
    /// <summary>
    /// BSON is a binary representation of Json like document
    /// It's important to note that we are talking about Json like document and not a json document
    /// BSON has more features that JSON
    /// BSON is way documents are stored in MongoDB
    /// The communication between the MongoDB sever and MongoDB client also happens through passing BSONs 
    /// </summary>
    public class Exercise001UnderstandingBson
    {
        /// <summary>
        /// The BsonDocument should be created in CSharp by the class BsonDocument
        /// We have created a empty Bson document and converted it to a json for viewing purposes
        /// </summary>
        [Test]
        public void Step01Information()
        {
            BsonDocument document = new BsonDocument();
            var json = document.ToJson();
            Console.WriteLine(json);
        }


        /// <summary>
        /// Create a bson document, the document should be as described below
        /// It should have a property named "Name" and its value should "Ankit"
        /// It should have a property named "Age" and its value should 30
        /// </summary>
        [Test]
        public void Step02Exercise()
        {
            var document = SpaceToDoStep02Exercise();
            var json = document.ToJson();
            Console.WriteLine(json);
            Assert.AreEqual(typeof(BsonDocument), document.GetType());
            Assert.AreEqual("Ankit", document["Name"].AsString);
            Assert.AreEqual(30, document["Age"].AsInt32);
        }

        private static BsonDocument SpaceToDoStep02Exercise()
        {
            //throw new NotImplementedException();
            BsonDocument document = new BsonDocument();
            document["Name"] = "Ankit";
            document.Add("Age", 30);
            return document;
        }
    }
}