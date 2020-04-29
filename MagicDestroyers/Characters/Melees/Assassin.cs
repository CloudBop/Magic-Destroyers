namespace MagicDestroyers.Characters.Melees
{
    using System;
    using MagicDestroyers.Armors.Leather;
    using MagicDestroyers.Weapons.Sharp;
    //
    public class Assassin
    {
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
        private Sword _weapon;

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
        public LeatherVest BodyArmor { 
            get { return this._bodyArmor; }
            set { this._bodyArmor = value; } 
        }

        public Sword Weapon
        {
            get { return this._weapon; }
            set { _weapon = value; }
        }
        
        //
        // Constructors Go Here
        //
        public Assassin()
            : this("Assassin", 1)
        {
        }
        public Assassin(string name, int level)
            : this(name, level, 10)
        {
        }
        public Assassin(string name, int healthPoints, int level)
        {
            this._faction = "Melee";
            this._name = name;
            this._abilityPoints = 10;
            this._healthPoints = healthPoints;
            this._level = level;
            this._bodyArmor = new LeatherVest();
            this._weapon = new Sword();
        }
        
        public void Raze()
        {
            throw new NotImplementedException();
        }
        
        public void Bleed()
        {
            throw new NotImplementedException();
        }
        
        public void Survival()
        {
            throw new NotImplementedException();
        }
    }
}