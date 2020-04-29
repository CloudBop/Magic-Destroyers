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
        private Chainlink _bodyArmor;
        private Axe _weapon;

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
                _faction = value;
            }
        }
        public string Name
        {
            get { return _name;}
            set { _name = value; }
        }
        // stats
        public int AbilityPoints
        {
            get { return _abilityPoints; }
            set { _abilityPoints = value; }
        }
        public int HealthPoints {
            get { return _healthPoints; }
            set { _healthPoints = value; }
        }
        public int Level
        {
            get { return _healthPoints; }
            set { _healthPoints = value; }
        }
        // equipment
        public Chainlink BodyArmor
        {
            get { return _bodyArmor; }
            set { _bodyArmor = value; }
        }
        public Axe Weapon 
        {
            get { return _weapon; }
            set { _weapon = value; }
        }
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