using MagicDestroyers.Characters.Enumerations;

namespace MagicDestroyers.Characters.Melees
{
    using System;
    using MagicDestroyers.Armors.Leather;
    using MagicDestroyers.Weapons.Sharp;
    //
    public class Assassin : Melee
    {
        private const string DEFAULT_NAME = "Assassin";
        private const Factions DEFAULT_FACTION = Factions.Melee;
        private const int DEFAULT_LEVEL = 1;
        private const int DEFAULT_ABILITY_POINTS = 10;
        private const int DEFAULT_HEALTH_POINTS = 10;
        // const cannot be objects
        private readonly Sword DEFAULT_WEAPON = new Sword();
        private readonly LeatherVest DEFAULT_BODY_ARMOR = new LeatherVest();
        
        // fields
        // equipment
        private LeatherVest _bodyArmor;
        private Sword _weapon;
        // properties
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
            : this(DEFAULT_NAME, DEFAULT_LEVEL)
        {
        }
        public Assassin(string name, int level)
            : this(name, level, DEFAULT_ABILITY_POINTS)
        {
        }
        public Assassin(string name, int level, int abilityPoints)
        {
            this.Name = name;
            this.Level = level;
            this.AbilityPoints = abilityPoints;
            this.HealthPoints = DEFAULT_HEALTH_POINTS;
            this.Faction = DEFAULT_FACTION;
            this._bodyArmor = DEFAULT_BODY_ARMOR;
            this._weapon = DEFAULT_WEAPON;
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