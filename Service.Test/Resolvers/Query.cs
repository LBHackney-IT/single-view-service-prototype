using NUnit.Framework;
using Service.Resolvers;

namespace Service.Test.Resolvers
{
    internal class QueryTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestSearchPerson()
        {
            var obj = new Query();
            Assert.IsEmpty(obj.SearchAsset());
        }
    }
}
