namespace MagicDestroyers.Armors.Leather
{
    using System;
    public class LeatherVest
    {
        private int _armorPoints;

        public int ArmorPoints
        {
            get { return _armorPoints; }
            set
            {
                if(_armorPoints>0)
                {
                    _armorPoints = value;
                }else
                {
                    Console.WriteLine($"ArmorPoints cannot be ${value}." +
                                      $"\n ArmorPoints has to be greater than 0" +
                                      $"\n ArmorPoints default to 1");
                    _armorPoints = 1;
                }
            }
        }
        public LeatherVest()
        {
            this._armorPoints = 10;
        }
    }
}