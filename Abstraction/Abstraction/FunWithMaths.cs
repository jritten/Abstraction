using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    public class FunWithMaths
    {
        public int MultiplyNumbers(INumberProvider provider)
        {
            int totalNums = 1;
            var numberArray = provider.GetNumbers();
            foreach(var number in numberArray)
            {
                totalNums *= number;
            }
            return totalNums;
        }
    }
}
