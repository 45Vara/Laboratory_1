using lab1;
using Microsoft.VisualStudio.TestPlatform.TestHost;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;
using Xunit;

namespace lab1_Test
{
    public class FileServiceTests
    {
        //первое отрицательное послденее положительно и найти сумму после минимально и после последнего положительного
        //что если первые числа не отрицательные или он самый последни

        [Fact]
        public void NegativeIsLastElement()
        {
            var numbs = new List<int> { 3, 5, 2, 4, 1, -2 };
            int result = lab1.Program.Numb(numbs);
            Assert.Equal(0, result);
        }

        [Fact]
        public void AllPositive()
        {
            var numbs = new List<int> { 1, 2, 3, 4, 5 };
            int result = lab1.Program.Numb(numbs);
            Assert.Equal(0, result);
        }

        [Fact]
        public void VeryLongListWithSum()
        {
            var numbs = new List<int> { -1, 2, 3, 4, 5, 6, 7, 8, 9, 10, -100, 1 };
            int result = lab1.Program.Numb(numbs);
            Assert.Equal(-46, result);
        }

        [Fact]
        public void AllNegative()
        {
            var numbs = new List<int> { -1, -2, -3, -4, -5 };
            int result = lab1.Program.Numb(numbs);
            Assert.Equal(0, result);
        }
    }
}
