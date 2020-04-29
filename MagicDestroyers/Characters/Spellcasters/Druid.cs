namespace MagicDestroyers.Characters.Spellcasters
{
    using System;
    using MagicDestroyers.Armors.Leather;
    using MagicDestroyers.Weapons.Blunt;
    public class Druid
    {
        private const string DEFAULT_NAME = "Necromancer";
        private const string DEFAULT_FACTION = "Spellcaster";
        private const int DEFAULT_LEVEL = 1;
        private const int DEFAULT_ABILITY_POINTS = 10;
        private const int DEFAULT_HEALTH_POINTS = 10;
        // const cannot be objects
        private readonly Staff DEFAULT_WEAPON = new Staff();
        private readonly LeatherVest DEFAULT_BODY_ARMOR = new LeatherVest();
        // fields
        // 
        private string _faction;
        private string _name;
        // stats
        private int _abilityPoints;
        private int _healthPoints;
        private int _level;
        // equipment
        private LeatherVest _bodyArmor;
        private Staff _weapon;

        // properties
        //
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
        public LeatherVest BodyArmor
        {
            get { return this._bodyArmor; }
            set { this._bodyArmor = value; }
        }

        public Staff Weapon
        {
            get { return this._weapon; }
            set { this._weapon = value; }
        }
        public Druid()
            : this(DEFAULT_NAME, DEFAULT_LEVEL)
        {
        }
        public Druid(string name, int level)
            : this(name, level, DEFAULT_ABILITY_POINTS)
        {
        }
        public Druid(string name, int level, int abilityPoints)
        {
            this._name = name;
            this._level = level;
            this._abilityPoints = abilityPoints;
            this._healthPoints = DEFAULT_HEALTH_POINTS;
            this._faction = DEFAULT_FACTION;
            this._bodyArmor = DEFAULT_BODY_ARMOR;
            this._weapon = DEFAULT_WEAPON;
        }
        
        public void Moonfire()
        {
            throw new NotImplementedException();
        }
        
        public void Starburst()
        {
            throw new NotImplementedException();
        }

        public void OneWithNature()
        {
            throw new NotImplementedException();
        }
    }
}