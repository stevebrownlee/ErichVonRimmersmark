using System;
using System.Collections.Generic;

namespace monsters
{
    public class Hunter
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public List<string> Weapons { get; } = new List<string>() {
            "Silver", "Fire", "Holy Water"
        };

        public Hunter (string first, string last) {
            FirstName = first;
            LastName = last;
        }

        public void Ignite (ICombustable burner) {
            burner.Burn("Blowtorch");
        }

        public void SplashWater (IUnholy spawn) {
            spawn.Douse("Holy Water");
        }

        public void WieldSilverSword (ISilverHater corrupt) {
            corrupt.Stab("Silver");
        }

        public void ThrowSillyPutty<T> (Monster<T> monster) {
            monster.Squish("Silly Putty");
        }

        public override string ToString () {
            return $"{FirstName} {LastName} kills monsters with the following weapons: {String.Join(", ", Weapons)}";
        }
    }
}