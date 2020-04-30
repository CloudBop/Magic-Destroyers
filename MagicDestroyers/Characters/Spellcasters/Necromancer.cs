using MagicDestroyers.Characters.Enumerations;

namespace MagicDestroyers.Characters.Spellcasters
{
    using System;
    using MagicDestroyers.Armors.Leather;
    using MagicDestroyers.Weapons.Sharp;

    public class Necromancer
    {
        private const string DEFAULT_NAME = "Necromancer";
        private const Factions DEFAULT_FACTION = Factions.Spellcaster;
        private const int DEFAULT_LEVEL = 1;
        private const int DEFAULT_ABILITY_POINTS = 10;
        private const int DEFAULT_HEALTH_POINTS = 10;
        // const cannot be objects
        private readonly Sword DEFAULT_WEAPON = new Sword();
        private readonly LeatherVest DEFAULT_BODY_ARMOR = new LeatherVest();
        // fields
        // 
        private Factions _faction;
        private string _name;
        // stats
        private int _abilityPoints;
        private int _healthPoints;
        private int _level;
        // equipment
        private LeatherVest _bodyArmor;
        private Sword _weapon;

        // properties
        //
        public Factions Faction
        {
            get
            {
                return this._faction;
            }
            set
            {    // keyword: value 
                this._faction = value;
            }
        }
        public string Name
        {
            get { return _name;}
            set
            {
                if (value.Length > 2 && value.Length <= 10)
                {
                    _name = value;
                }
                else
                {
                    Console.WriteLine($"Invalid name: {value}" +
                                      $"\n Name should contain more than 3 characters and less than 11" +
                                      $"defaults to: Unknown");
                    _name = "Unknown";
                }
            }
        }
        // stats
        public int AbilityPoints
        {
            get { return _abilityPoints; }
            set
            {
                if (value >= 0)
                {
                    _abilityPoints = value;
                }
                else
                {
                    Console.WriteLine($"Invalid Number: {value} \n" +
                                      $"AbilityPoints must be greater than 0");
                    _abilityPoints = 1;
                }
            }
        }
        public int HealthPoints {
            get { return _healthPoints; }
            set
            {
                if (value >= 0)
                {
                    _healthPoints = value;
                }
                else
                {
                    Console.WriteLine($"Invalid Number: {value} \n" +
                                      $"HealthPoints must be greater than 0");
                    _healthPoints = 1;
                }
            }
        }
        public int Level
        {
            get { return _level; }
            set
            {
                if (value >= 0)
                {
                    _level = value;
                }
                else
                {
                    Console.WriteLine($"Invalid Number: {value} \n" +
                                      $"_level must be greater than 0");
                    throw new ArgumentOutOfRangeException(string.Empty, "Inappropriate value! Level must be greater than 1!");
                    _level = 1;
                }
            }
        }
        // equipment
        public LeatherVest BodyArmor
        {
            get { return this._bodyArmor; }
            set { this._bodyArmor = value; }
        }

        public Sword Weapon
        {
            get { return this._weapon; }
            set { this._weapon = value; }
        }
        //
        //
        //
        public Necromancer()
            : this(DEFAULT_NAME, DEFAULT_LEVEL)
        {
        }
        public Necromancer(string name, int level)
            : this(name, level, DEFAULT_ABILITY_POINTS)
        {
        }
        public Necromancer(string name, int level, int abilityPoints)
        {
            this._name = name;
            this._level = level;
            this._abilityPoints = abilityPoints;
            this._healthPoints = DEFAULT_HEALTH_POINTS;
            this._faction = DEFAULT_FACTION;
            this._bodyArmor = DEFAULT_BODY_ARMOR;
            this._weapon = DEFAULT_WEAPON;
        }
        
        public void ShadowRage()
        {
            throw new NotImplementedException(); 
        }

        public void VampireTouch()
        {
            throw new NotImplementedException();
        }

        public void BoneShield()
        {
            throw new NotImplementedException();
        }
    }
}