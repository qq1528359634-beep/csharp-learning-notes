using Xunit;
using Moq;

namespace FunExample.Tests
{
    public class DeskFanTests
    {
        [Fact]
        public void PowerLowerThanZero_Ok()
        {
            var mock = new Mock<IPowerSupply>();
            mock.Setup(s=>s.GetPower()).Returns(()=>0);
            var fan=new DeskFan(mock.Object);
            var expected = "Won't work";
            var actual = fan.Work();
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void PowerhigherThan200()
        {
            var mock = new Mock<IPowerSupply>();
            mock.Setup(s => s.GetPower()).Returns(() => 200);
            var fan = new DeskFan(mock.Object);
            var expected = "Warning";
            var actual = fan.Work();
            Assert.Equal(expected, actual);
        }
    }
/*    class PowerSupplyLowerThanZero : IPowerSupply
    {
        public int GetPower()
        {
            return 0;
        }
    }
    class PowerSupplyLowerThan200 : IPowerSupply
    {
        public int GetPower()
        {
            return 300;
        }
    }*/
}
