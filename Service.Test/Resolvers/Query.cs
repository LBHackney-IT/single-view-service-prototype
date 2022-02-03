using NUnit.Framework;
using Resolvers;

namespace Service.Test.Resolvers
{
    internal class QueryTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            var obj = new Query();

            Assert.AreEqual(obj.GetMovieById(1)?.Title, "The Rise of the GraphQL Warrior");
            Assert.Pass();
        }
    }
}
