namespace MagicDestroyers.Characters.Melees
{
    using System;
    using MagicDestroyers.Armors.Mail;
    using MagicDestroyers.Weapons.Sharp;

    public class Warrior
    {
        // Constants
        private const string DEFAULT_NAME = "Warror";
        private const string DEFAULT_FACTION = "Melee";
        private const int DEFAULT_LEVEL = 1;
        private const int DEFAULT_ABILITY_POINTS = 10;
        private const int DEFAULT_HEALTH_POINTS = 10;
        // const cannot be objects
        private readonly Axe DEFAULT_WEAPON = new Axe();
        private readonly Chainlink DEFAULT_BODY_ARMOR = new Chainlink();

        // fields
        //
        private string _faction;
        private string _name;
        private int _abilityPoints;
        private int _healthPoints;
        private int _level;
        //
        private Chainlink _bodyArmor;
        private Axe _weapon;

        // properties
        public string Faction
        {
            get
            {
                return this._faction;
            }
            set
            {    // keyword: value 
                if (value == "Melees"|| value == "Spellcasters")
                {
                    this._faction = value;
                }
                else
                {
                    Console.WriteLine($"the faction: \"{value}\" is not a valid faction, no default");
                }
            }
        }
        public string Name
        {
            get { return this._name;}
            set
            {
                if (value.Length > 2 && value.Length <= 10)
                {
                    this._name = value;
                }
                else
                {
                    Console.WriteLine($"Invalid name: {value}" +
                                      $"\n Name should contain more than 3 characters and less than 11" +
                                      $"defaults to: Unknown");
                    this._name = "Unknown";
                }
            }
        }
        // stats
        public int AbilityPoints
        {
            get { return this._abilityPoints; }
            set
            {
                if (value >= 0)
                {
                    this._abilityPoints = value;
                }
                else
                {
                    Console.WriteLine($"Invalid Number: {value} \n" +
                                      $"AbilityPoints must be greater than 0");
                    this._abilityPoints = 1;
                }
            }
        }
        public int HealthPoints {
            get { return this._healthPoints; }
            set
            {
                if (value >= 0)
                {
                    this._healthPoints = value;
                }
                else
                {
                    Console.WriteLine($"Invalid Number: {value} \n" +
                                      $"HealthPoints must be greater than 0");
                    this._healthPoints = 1;
                }
            }
        }
        public int Level
        {
            get { return this._level; }
            set
            {
                if (value >= 0)
                {
                    this._level = value;
                }
                else
                {
                    Console.WriteLine($"Invalid Number: {value} \n" +
                                      $"_level must be greater than 0");
                    this._level = 1;
                }
            }
        }
        // equipment
        public Chainlink BodyArmor
        {
            get { return this._bodyArmor; }
            set { this._bodyArmor = value; }
        }
        public Axe Weapon 
        {
            get { return this._weapon; }
            set { this._weapon = value; }
        }
        //
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
        {
            this._name = name;
            this._level = level;
            this._abilityPoints = abilityPoints;
            this._healthPoints = DEFAULT_HEALTH_POINTS;
            this._faction = DEFAULT_FACTION;
            this._bodyArmor = DEFAULT_BODY_ARMOR;
            this._weapon = DEFAULT_WEAPON;
        }
        public void Strike()
        {
            throw new NotImplementedException();
        }

        public void Execute()
        {
            throw new NotImplementedException();
        }
        
        public void SkinHarden()
        {
            throw new NotImplementedException();
        }
    }
}