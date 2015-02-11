using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Example1.Test
{
    class FirstLetterEqualityComparer: IEqualityComparer<PersonWithEquals> 
    {
        public bool Equals(PersonWithEquals a, PersonWithEquals b)
        {
            return a.Name[0] == b.Name[0];
        }

        public int GetHashCode(PersonWithEquals obj)
        {
            throw new NotImplementedException();
        }
    }
}
