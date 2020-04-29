namespace MagicDestroyers.Characters.Melees
{
    using MagicDestroyers.Armors.Mail;
    using MagicDestroyers.Weapons.Sharp;

    public class Warrior
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
        private Chainlink bodyArmor;
        private Axe weapon;

        // properties
        //
        public string Faction { get; set; }
        public string Name { get; set; }
        // stats
        public int AbilityPoints { get; set; }
        public int HealthPoints { get; set; }
        public int Level { get; set; }
        // equipment
        public Chainlink BodyArmor { get; set; }
        public Axe Weapon { get; set; }
        //
        public void Strike()
        {

        }

        public void Execute()
        {
            
        }
        
        public void SkinHarden()
        {

        }
    }
}