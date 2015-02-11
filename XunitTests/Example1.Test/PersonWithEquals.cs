using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Example1.Test
{
    class PersonWithEquals
    {
        public string Name { get; set; }

        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }

            var p = obj as PersonWithEquals;

            if (p == null)
            {
                return false;
            }

            return (p.Name == Name);
        }
    }
}
