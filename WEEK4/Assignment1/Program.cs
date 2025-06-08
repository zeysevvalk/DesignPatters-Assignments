using System;

namespace Assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            new Program().Start();
        }

        void Start()
        {
            List<Character> characters = new List<Character>();
            characters.Add(new Queen());
            characters.Add(new Troll());
            characters.Add(new King());
            characters.Add(new Knight());

            Console.WriteLine("Initial weapons:");
            foreach (Character character in characters)
                character.Fight();

            Console.WriteLine("\nChanging knight's weapon to axe...\n");

            characters[3].Weapon = new AxeBehaviour();

            foreach (Character character in characters)
                character.Fight();

        }
    }
}