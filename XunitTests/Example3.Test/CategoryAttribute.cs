using Xunit;
using Xunit.Extensions;
using System.Reflection;

namespace Example3.Test
{
    public class CategoryAttribute : TraitAttribute
    {
        public CategoryAttribute(string categoryName)
            : base("Category", categoryName)
        {

        }
    }
}
