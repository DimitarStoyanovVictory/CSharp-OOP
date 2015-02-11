using System.Collections.Generic;

namespace Example3.Test
{
    public static class PropertyTestDataSource
    {
        private static List<object[]> data = new List<object[]>
        {
            new object[] {9, true},
            new object[] {10, false},
            new object[] {11, false},
            new object[] {-1, true}
        };

        public static IEnumerable<object[]> TestData
        {
            get { return data; }
        }
    }
}
