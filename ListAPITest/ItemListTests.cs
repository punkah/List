using ListAPI.Models;
using Xunit;

namespace ListAPITest
{
    public class ItemListTests
    {
        [Fact]
        public void TestConstructor()
        {
            Assert.Equal(2, ItemList.Count());
        }
    }
}