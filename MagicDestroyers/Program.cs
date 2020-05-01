using System;
using System.Collections.Generic;
using MagicDestroyers.Characters;
using MagicDestroyers.Characters.Melees;
using MagicDestroyers.Characters.Spellcasters;

namespace MagicDestroyers
{
    class Program
    {
        static void Main()
        {
            WelcomeMessage();
            // create warrior myFirstInstance = new Warrior();
            List<Character> characters = new List<Character>()
            {
                new Warrior(),
                new Mage(),
                new Warrior(),
                new Mage(),
                new Warrior(),
                new Mage(),
            };
            //
            List<Melee> meleeTeam = new List<Melee>();
            List<Spellcaster> spellTeam = new List<Spellcaster>();
            //
            foreach (var character in characters)
            {
                if (character is Melee)
                {
                    meleeTeam.Add((Melee)character);
                }
                else if (character is Spellcaster)
                {
                    spellTeam.Add((Spellcaster)character);
                }
            }
        }

        static void WelcomeMessage()
        {
            Tools.ColorfulWriteLine("Welcome To Magic Destroyers", ConsoleColor.Blue);
        }
    }
}