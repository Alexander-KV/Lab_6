using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorApp.Tests
{
    public class CalculatorTests
    {
        [Fact]
        public void Add_ReturnsCorrectSum()
        {
            Calculator calc = new Calculator();
            int result = calc.add(2, 3);
            Assert.Equal(5, result);
        }
    }
}
