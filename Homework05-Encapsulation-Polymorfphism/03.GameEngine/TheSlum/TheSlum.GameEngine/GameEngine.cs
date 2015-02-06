using System;
using TheSlum.Characters;
using TheSlum.Items;

namespace TheSlum.GameEngine
{
    public class DesignedEngine : Engine
    {
        protected override void ExecuteCommand(string[] inputParams)
        {
            if (inputParams.Length == 6)
            {
                CreateCharacter(inputParams);
            }
            else if (inputParams.Length == 4)
            {
                AddItem(inputParams);
            }
            else
            {
                PrintCharactersStatus(characterList);
            }
        }

        protected override void CreateCharacter(string[] inputParams)
        {
            Team team = new Team();

            switch (inputParams[5])
            {
                case "Red": team = Team.Red; break;
                case "Blue": team = Team.Blue; break;
            }

            switch (inputParams[1])
            {
                case "warrior": characterList.Add(new Warrior(inputParams[2], Convert.ToInt32(inputParams[3]), Convert.ToInt32(inputParams[4]), team)); break;
                case "mage": characterList.Add(new Mage(inputParams[2], Convert.ToInt32(inputParams[3]), Convert.ToInt32(inputParams[4]), team)); break;
                case "healer": characterList.Add(new Healer(inputParams[2], Convert.ToInt32(inputParams[3]), Convert.ToInt32(inputParams[4]), team)); break;
            }
        }

        protected new void AddItem(string[] inputParams)
        {
            Item item = new Axe("");

            switch (inputParams[2])
            {
                case "axe": item = new Axe(inputParams[3]); break;
                case "shield": item = new Shield(inputParams[3]); break;
                case "pill": item = new Pill(inputParams[3]); break;
                case "injection": item = new Injection(inputParams[3]); break;
            }

            characterList[characterList.Count - 1].AddToInventory(item);
        }
    }
}
