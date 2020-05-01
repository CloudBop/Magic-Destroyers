using MagicDestroyers.Characters.Enumerations;

namespace MagicDestroyers.Characters.Melees
{
    using System;
    using MagicDestroyers.Armors.Mail;
    using MagicDestroyers.Weapons.Sharp;

    public class Warrior : Melee
    {
        // Constants
        private const string DEFAULT_NAME = "Warror";
        private const Factions DEFAULT_FACTION = Factions.Melee;
        private const int DEFAULT_LEVEL = 1;
        private const int DEFAULT_ABILITY_POINTS = 10;
        private const int DEFAULT_HEALTH_POINTS = 10;
        // const cannot be objects
        private readonly Axe DEFAULT_WEAPON = new Axe();
        private readonly Chainlink DEFAULT_BODY_ARMOR = new Chainlink();
        
        // constructor
        public Warrior()
            : this(DEFAULT_NAME, DEFAULT_LEVEL)
        {
        }
        public Warrior(string name, int level)
            : this(name, level, DEFAULT_ABILITY_POINTS)
        {
        }
        public Warrior(string name, int level, int abilityPoints)
            :base(name, level, abilityPoints)
        {
            base.HealthPoints = DEFAULT_HEALTH_POINTS;
            base.Faction = DEFAULT_FACTION;
            base.BodyArmor = DEFAULT_BODY_ARMOR;
            base.Weapon = DEFAULT_WEAPON;
        }
        public int Strike()
        {
            throw new NotImplementedException();
        }

        public int Execute()
        {
            throw new NotImplementedException();
        }
        
        public int SkinHarden()
        {
            throw new NotImplementedException();
        }
        // example of static method
        public static void LogAllDefaultSettings(Warrior warrior)
        {
            // notice how Warrior instance has to be argument as readonly objects are on the class instance itself
            // not ideal, static methods shouldn't need instance. only in rare cases
            Console.WriteLine($"default name:{DEFAULT_NAME}" +
                              $"\ndefault level:{DEFAULT_LEVEL}" +
                              $"\ndefault HP   :{DEFAULT_HEALTH_POINTS}" +
                              $"\ndefault AP :{DEFAULT_ABILITY_POINTS}" +
                              $"\ndefault Faction:{DEFAULT_FACTION}" +
                              $"\ndefault Weapon:{warrior.DEFAULT_WEAPON}" +
                              $"\ndefault Armor:{warrior.DEFAULT_BODY_ARMOR}"
                              );
        }
        //
        public override int Attack()
        {
            return this.Strike();
        }

        public override int SpecialAttack()
        {
            return this.Execute();
        }

        public override int Defend()
        {
            return this.SkinHarden();
        }
    }
}