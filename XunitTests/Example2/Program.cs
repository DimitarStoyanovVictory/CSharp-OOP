using System.Collections.Generic;
using System.Linq;
using Xunit; 

namespace Example2
{
    public class AssertEqualWithEnumerables
    {
        [Fact]
        public void ValueTypesEqual()
        {
            IEnumerable<int> numbers1 = Enumerable.Range(1, 10);
            IEnumerable<int> numbers2 = Enumerable.Range(1, 10);

            Assert.Equal(numbers1, numbers2); 
        }
    }
}
