using NUnit.Framework;
using Service.Boundary.HackneyApi.HousingSearh;

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
            Assert.IsEmpty(new PersonResult[] { });
        }
    }
}
