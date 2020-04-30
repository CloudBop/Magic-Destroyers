using MagicDestroyers.Characters.Enumerations;

namespace MagicDestroyers.Characters.Spellcasters
{
    using System;
    using MagicDestroyers.Armors.Leather;
    using MagicDestroyers.Weapons.Sharp;

    public class Necromancer : Spellcaster
    {
        private const string DEFAULT_NAME = "Necromancer";
        private const Factions DEFAULT_FACTION = Factions.Spellcaster;
        private const int DEFAULT_LEVEL = 1;
        private const int DEFAULT_MANA_POINTS = 10;
        private const int DEFAULT_HEALTH_POINTS = 10;
        // const cannot be objects
        private readonly Sword DEFAULT_WEAPON = new Sword();
        private readonly LeatherVest DEFAULT_BODY_ARMOR = new LeatherVest();
        
        // equipment
        private LeatherVest _bodyArmor;
        private Sword _weapon;

        // properties
        //
        
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
            : this(name, level, DEFAULT_MANA_POINTS)
        {
        }
        public Necromancer(string name, int level, int manaPoints)
            :base(name, level, manaPoints)

        {
            base.HealthPoints = DEFAULT_HEALTH_POINTS;
            base.Faction = DEFAULT_FACTION;
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