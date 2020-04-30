using System;

namespace MagicDestroyers.Characters.Melees
{
    public class Melee : Character
    {
        private int _abilityPoints;
        public int AbilityPoints
        {
            get { return this._abilityPoints; }
            set
            {
                if (value >= 0)
                {
                    this._abilityPoints = value;
                }
                else
                {
                    Console.WriteLine($"Invalid Number: {value} \n" +
                                      $"AbilityPoints must be greater than 0");
                    this._abilityPoints = 1;
                }
            }
        }

        protected Melee(string name, int level, int abilityPoints)
            : base(name, level)
        {
            base.Name = name;
            base.Level = level;
            this.AbilityPoints = abilityPoints;
        }
    }
}