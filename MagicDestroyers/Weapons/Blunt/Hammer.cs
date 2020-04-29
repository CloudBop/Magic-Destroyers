using System;

namespace MagicDestroyers.Weapons.Blunt
{
    public class Hammer
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
        //
        public Hammer()
        {
            _damage = 10;
        }
        public void Stun()
        {
            throw new NotImplementedException();
        }
    }
}