using System;

namespace Task07.Examples
{
    class PlayWithCatAndSequance
    {
        public static void Main()
        {
            Cat[] cats = new Cat[10];

            int n = 0;

            for (int i = 1; i < 11; i++, n++)
            {
                cats[n] = new Cat();
                cats[n].Name = "cat" + i;
            }

            foreach (var item in cats)
            {
                item.SayMiau();
            }
        }
    }
}
