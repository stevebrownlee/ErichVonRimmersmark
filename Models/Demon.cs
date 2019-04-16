using System;

namespace monsters {
    public class Demon : Monster<Demon>, ICombustable, ISilverHater, IUnholy {
        public void Burn (string attack) {
            if (attack == "Fire") {
                Console.WriteLine ("The demon burns into a pile of ash.");
            }
        }

        public void Douse (string attack) {
            if (attack == "Holy Water") {
                Console.WriteLine ("The demon melts into a black puddle of goo.");
            }
        }

        public void Stab (string attack) {
            if (attack == "Silver") {
                Console.WriteLine ("The demon explodes into a cloud of fine dust.");
            }

        }
    }

}