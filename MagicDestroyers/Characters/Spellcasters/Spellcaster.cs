using System;

namespace MagicDestroyers.Characters.Spellcasters
{
    public class Spellcaster : Character
    {
        private int _manaPoints;
        public int ManaPoints
        {
            get { return this._manaPoints; }
            set
            {
                if (value >= 0)
                {
                    this._manaPoints = value;
                }
                else
                {
                    Console.WriteLine($"Invalid Number: {value} \n" +
                                      $"AbilityPoints must be greater than 0");
                    this._manaPoints = 1;
                }
            }
        }
        protected Spellcaster(string name, int level, int manaPoints)
            : base(name, level)
        {
            base.Name = name;
            base.Level = level;
            this.ManaPoints = manaPoints;
        }
    }
}