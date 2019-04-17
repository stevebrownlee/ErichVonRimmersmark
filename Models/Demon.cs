using System;

namespace monsters {
    public class Demon : Monster<Demon>, ICombustable, ISilverHater, IUnholy {
        public void Burn (string attack) {
            if (attack == "Fire") {
                Console.WriteLine ($"The {attack.ToLower()} causes the demon to burn into a pile of ash.");
            }
        }

        public void Douse (string attack) {
            if (attack == "Holy Water") {
                Console.WriteLine ($"The {attack.ToLower()} makes the demon melt into a black puddle of goo.");
            }
        }

        public void Stab (string attack) {
            if (attack == "Silver") {
                Console.WriteLine ($"After being stabbed by the {attack.ToLower()}, the demon explodes into a cloud of fine dust.");
            }

        }
    }

}