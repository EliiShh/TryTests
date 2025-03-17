using Xunit;

namespace TryTests.Test
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            Person p = new Person();
            p.Name = "Eli";
            Assert.Equal(p.Name, "Eli");
            Console.WriteLine("tests goooooooodddddd");
        }
    }
}