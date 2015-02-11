using System;

namespace Task07
{
    class Sequance
    {
        private static int currentValue = 0;
 
      // Intentionally deny instantiation of this class
      public Sequance()
      {
      }
 
      // Static method for taking the next sequence value
      public static int NextValue()
      {
            currentValue++;
            return currentValue;
      }
    }
}
