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
        private ClothRobe _bodyArmor;
        private Staff _weapon;

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
        public ClothRobe BodyArmor
        {
            get { return _bodyArmor; }
            set { _bodyArmor = value; }
        }

        public Staff Weapon
        {
            get { return _weapon; }
            set { _weapon = value; }
        }
        
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