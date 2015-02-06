using System;
using System.Collections.Generic;

namespace GameEngine
{
    public class Engine
    {
        public Engine(List<Character> characters)
        {
            this.Characters = characters;
        }
        public List<Character> Characters { get; set; }

        public void Input()
        {
            string[] input;
            while (true)
            {
                input = Console.ReadLine().Split(' ');
                if (input.Length == 6)
                {
                    Create(input[1], input[2], input[3], input[4], input[5]);
                }
            }
        }

        public Character Create(string id, string name, int x, int y, string team)
        {
            
        } 


    }
}
