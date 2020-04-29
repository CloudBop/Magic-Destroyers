namespace MagicDestroyers.Characters.Spellcasters
{
    using MagicDestroyers.Armors.Leather;
    using MagicDestroyers.Weapons.Blunt;
    public class Druid
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
        private LeatherVest bodyArmor;
        private Staff weapon;

        // properties
        //
        public string Faction { get; set; }
        public string Name { get; set; }
        // stats
        public int AbilityPoints { get; set; }
        public int HealthPoints { get; set; }
        public int Level { get; set; }
        // equipment
        public LeatherVest BodyArmor { get; set; }
        public Staff Weapon { get; set; }
        
        public void Moonfire()
        {

        }
        
        public void Starburst()
        {

        }

        public void OneWithNature()
        {
            
        }
    }
}