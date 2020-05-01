// using MagicDestroyers.Characters.Enumerations;
//
// namespace MagicDestroyers.Characters.Melees
// {
//     using System;
//     using MagicDestroyers.Armors.Mail;
//     using MagicDestroyers.Weapons.Blunt;
//
//     public class Knight : Melee
//     {
//         private const string DEFAULT_NAME = "Knight";
//         private const Factions DEFAULT_FACTION = Factions.Melee;
//         private const int DEFAULT_LEVEL = 1;
//         private const int DEFAULT_ABILITY_POINTS = 10;
//         private const int DEFAULT_HEALTH_POINTS = 10;
//         // const cannot be objects
//         private readonly Hammer DEFAULT_WEAPON = new Hammer();
//         private readonly Chainlink DEFAULT_BODY_ARMOR = new Chainlink();
//         // fields
//         // equipment
//         private Chainlink _bodyArmor;
//         private Hammer _weapon;
//         // properties
//         // equipment
//         public Chainlink BodyArmor
//         {
//             get { return this._bodyArmor; }
//             set { _bodyArmor = value; }
//         }
//
//         public Hammer Weapon
//         {
//             get { return this._weapon; }
//             set { this._weapon = value; }
//         }
//         public Knight()
//             : this(DEFAULT_NAME, DEFAULT_LEVEL)
//         {
//         }
//         public Knight(string name, int level)
//             : this(name, level, DEFAULT_ABILITY_POINTS)
//         {
//         }
//         public Knight(string name, int level, int abilityPoints)
//             :base(name, level, abilityPoints)
//         {
//             base.HealthPoints = DEFAULT_HEALTH_POINTS;
//             base.Faction = DEFAULT_FACTION;
//             this._bodyArmor = DEFAULT_BODY_ARMOR;
//             this._weapon = DEFAULT_WEAPON;
//         }
//         
//         public void HolyBlow()
//         {
//             throw new NotImplementedException();
//         }
//         
//         public void PurifySoul()
//         {
//             throw new NotImplementedException();
//         }
//
//         public void RighteousWings()
//         {
//             throw new NotImplementedException();
//         }
//     }
// }