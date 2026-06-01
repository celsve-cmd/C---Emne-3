using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace CodeAlong_Emne3
{
    internal class Animals
    {
        public void AnimalPicker()
        {
            string[] animals = new string[] { "Hund", "Katt", "Mus", "Fisk" };

            while (true)
            {
                PrintAnimals(animals);

                var input = Console.ReadLine();
                string sound = GetAnimalSound(input);

                if (sound == null)
                    break;

                Console.WriteLine($"{sound}\n");
            }
        }

        private void PrintAnimals(string[] animals)
        {
            Console.WriteLine("Velg et dyr:");
            for (int i = 0; i < animals.Length; i++)
            {
                Console.WriteLine($"{i} - {animals[i]}");
            }
        }

        private string GetAnimalSound(string input)
        {
            switch (input)
            {
                case "0": return "voff";
                case "1": return "mjau";
                case "2": return "pip";
                case "3": return "blubb blubb";
                default: return null;
            }
        }
    }
}




