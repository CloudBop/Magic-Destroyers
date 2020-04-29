using System;

namespace MagicDestroyers.Weapons.Sharp
{
    public class Sword
    {
        private int _damage;

        public int Damage
        {
            get { return _damage; }
            set
            {
                if(_damage>0)
                {
                    _damage = value;
                }else
                {
                    Console.WriteLine($"Damage cannot be ${value}. Damage has to be greater than 0");
                    _damage = 1;
                }
            }
        }
        public void Bloodthirst()
        {

        }
    }
}