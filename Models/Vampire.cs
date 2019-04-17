using System;

namespace monsters
{
    public class Vampire : Monster<Vampire>, ICombustable, ISilverHater
    {
        public void Burn (string attack)
        {
            if (attack == "Fire") {
                Console.WriteLine ($"The {attack.ToLower()} causes the vampire to burn like an oily rag until it's dead.");
            }
        }

        public void Stab (string attack)
        {
            if (attack == "Silver") {
                Console.WriteLine ($"The {attack.ToLower()} causes the vampire to bleed black blood from the wound and dies.");
            }
        }

        public override string ToString()
        {
            return "Vampire";
        }
    }
}
