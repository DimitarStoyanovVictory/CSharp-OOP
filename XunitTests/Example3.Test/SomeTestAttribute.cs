using Xunit;

namespace Example3.Test
{
    class SomeTestAttribute : TraitAttribute
    {
        public SomeTestAttribute()
            : base("Category", "SmokeTest")
        {

        } 
    }
}
