namespace MagicDestroyers.Weapons
{
    public abstract class Weapon
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
                    // Console.WriteLine($"Damage cannot be ${value}. Damage has to be greater than 0");
                    _damage = 1;
                }
            }
        }
        protected Weapon()
        {
            this.Damage = 10;
        }
    }
}