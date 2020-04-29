namespace MagicDestroyers.Characters.Spellcasters
{
    using System;
    using MagicDestroyers.Armors.Leather;
    using MagicDestroyers.Weapons.Sharp;

    public class Necromancer
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
                return _faction;
            }
            set
            {    // keyword: value 
                if (value == "Melees"|| value == "Spellcasters")
                {
                    _faction = value;
                }
                else
                {
                    Console.WriteLine($"the faction: \"{value}\" is not a valid faction, no default");
                }
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
                    _level = 1;
                }
            }
        }
        // equipment
        public LeatherVest BodyArmor
        {
            get { return _bodyArmor; }
            set { _bodyArmor = value; }
        }

        public Sword Weapon
        {
            get { return _weapon; }
            set { _weapon = value; }
        }
        
        public void ShadowRage()
        {

        }

        public void VampireTouch()
        {
            
        }

        public void BoneShield()
        {
            
        }
    }
}