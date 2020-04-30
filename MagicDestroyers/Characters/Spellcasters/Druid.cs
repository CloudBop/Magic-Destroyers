using MagicDestroyers.Characters.Enumerations;

namespace MagicDestroyers.Characters.Spellcasters
{
    using System;
    using MagicDestroyers.Armors.Leather;
    using MagicDestroyers.Weapons.Blunt;
    public class Druid : Spellcaster
    {
        private const string DEFAULT_NAME = "Druid";
        private const Factions DEFAULT_FACTION = Factions.Spellcaster;
        private const int DEFAULT_LEVEL = 1;
        private const int DEFAULT_MANA_POINTS = 10;
        private const int DEFAULT_HEALTH_POINTS = 10;
        // const cannot be objects
        private readonly Staff DEFAULT_WEAPON = new Staff();
        private readonly LeatherVest DEFAULT_BODY_ARMOR = new LeatherVest();
        // fields
        // equipment
        private LeatherVest _bodyArmor;
        private Staff _weapon;
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
            : this(name, level, DEFAULT_MANA_POINTS)
        {
        }
        public Druid(string name, int level, int manaPoints)
            :base(name, level, manaPoints)

        {
            base.HealthPoints = DEFAULT_HEALTH_POINTS;
            base.Faction = DEFAULT_FACTION;
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