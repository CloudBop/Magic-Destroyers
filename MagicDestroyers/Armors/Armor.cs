namespace MagicDestroyers.Armors
{
    public abstract class Armor
    {
        private int _armorPoints;

        public int ArmorPoints
        {
            get { return _armorPoints; }
            set {
                if(_armorPoints>0)
                {
                    _armorPoints = value;
                }else
                {
                    // Console.WriteLine($"ArmorPoints cannot be ${value}. ArmorPoints has to be greater than 0");
                    _armorPoints = 1;
                }
            }
        }
    }
}