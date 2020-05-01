using System;
using MagicDestroyers.Armors;
using MagicDestroyers.Weapons;
using MagicDestroyers.Characters.Enumerations;
using MagicDestroyers.Characters.Interfaces;

namespace MagicDestroyers.Characters
{
    public abstract class Character : IAttack, IDefend
    {
        private string _name;
        private int _healthPoints;
        private int _level;
        private Factions _faction;
        private Armor _bodyArmor;
        private Weapon _weapon;
        
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
        public Armor BodyArmor
        {
            get { return this._bodyArmor; }
            set { this._bodyArmor = value; }
        }
        public Weapon Weapon 
        {
            get { return this._weapon; }
            set { this._weapon = value; }
        }
        //
        protected Character(string name, int level)
        {
            this.Name = name;
            this.Level = level;
        }

        public abstract int Attack();

        public abstract int SpecialAttack();

        public abstract int Defend();
    }
}