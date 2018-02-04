using ListAPI.Controllers;
using Xunit;

namespace ListAPITest
{
    public class ItemListTests
    {
        [Fact]
        public void TestConstructor()
        {
            var itemlist = new ItemList();

            Assert.Equal(2, itemlist.Count());
        }
    }
}