using Xunit;

namespace TestyXUnit
{
    public class UnitTest1
    {
        [Fact]
        public void Dodatnia_delta()
        {
            var pierw = new Pierwiastki();

            var result = pierw.Add(1, -3, 2);

            Assert.Equal(1, pierw.x1);
            Assert.Equal(2, pierw.x2);
        }

        [Fact]
        public void Zerowa_delta()
        {
            var pierw = new Pierwiastki();

            var result = pierw.Add(1, -2, 1);

            Assert.Equal(1, pierw.x0);
        }

        [Fact]
        public void Ujemna_delta()
        {
            var pierw = new Pierwiastki();

            var result = pierw.Add(1, 2,3);

            Assert.Equal();
        }
    }
}