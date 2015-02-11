using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Example1.Test
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

        [Fact]
        public void ReferenceTypesWithOverridenEquals()
        {
            var people1 = new List<PersonWithEquals>
            {
                new PersonWithEquals {Name = "Sarah"},
                new PersonWithEquals {Name = "Gentry"}
            };
            var people2 = new List<PersonWithEquals>
            {
                new PersonWithEquals {Name = "Sarah"},
                new PersonWithEquals {Name = "Gentry"}
            };

            Assert.Equal(people1, people2);
        }
    }
}
