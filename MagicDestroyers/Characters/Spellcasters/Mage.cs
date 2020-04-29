namespace MagicDestroyers.Characters.Spellcasters
{
    using MagicDestroyers.Armors.Cloth;
    using MagicDestroyers.Weapons.Blunt;
    public class Mage
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
        private ClothRobe bodyArmor;
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
        public ClothRobe BodyArmor { get; set; }
        public Staff Weapon { get; set; }
        
        public void ArcaneWrath()
        {

        }
        
        public void FireWall()
        {

        }
        
        public void Meditation()
        {

        }
    }
}