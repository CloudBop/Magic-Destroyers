namespace MagicDestroyers.Characters.Melees
{
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
        private LeatherVest bodyArmor;
        private Sword weapon;

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
        public Sword Weapon { get; set; }
        
        public void Raze()
        {

        }
        
        public void Bleed()
        {

        }
        
        public void Survival()
        {

        }
    }
}