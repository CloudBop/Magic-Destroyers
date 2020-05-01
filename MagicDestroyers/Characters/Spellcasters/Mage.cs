using MagicDestroyers.Characters.Enumerations;

namespace MagicDestroyers.Characters.Spellcasters
{
    using System;
    using MagicDestroyers.Armors.Cloth;
    using MagicDestroyers.Weapons.Blunt;
    public class Mage : Spellcaster
    {
        private const string DEFAULT_NAME = "Mage";
        private const Factions DEFAULT_FACTION = Factions.Spellcaster;
        private const int DEFAULT_LEVEL = 1;
        private const int DEFAULT_MANA_POINTS = 10;
        private const int DEFAULT_HEALTH_POINTS = 10;
        // const cannot be objects
        private readonly Staff DEFAULT_WEAPON = new Staff();
        private readonly ClothRobe DEFAULT_BODY_ARMOR = new ClothRobe();
        // equipment
        public Mage()
            : this(DEFAULT_NAME, DEFAULT_LEVEL)
        {
        }
        public Mage(string name, int level)
            : this(name, level, DEFAULT_MANA_POINTS)
        {
        }
        public Mage(string name, int level, int manaPoints)
            :base(name, level, manaPoints)

        {
            base.HealthPoints = DEFAULT_HEALTH_POINTS;
            base.Faction = DEFAULT_FACTION;
            base.BodyArmor = DEFAULT_BODY_ARMOR;
            base.Weapon = DEFAULT_WEAPON;
        }
        
        public int ArcaneWrath()
        {
            throw new NotImplementedException();
        }
        
        public int FireWall()
        {
            throw new NotImplementedException();
        }
        
        public int Meditation()
        {
            throw new NotImplementedException();
        }
        
        public override int Attack()
        {
            return this.ArcaneWrath();
        }

        public override int SpecialAttack()
        {
            return this.FireWall();
        }

        public override int Defend()
        {
            return this.Meditation();
        }
    }
}