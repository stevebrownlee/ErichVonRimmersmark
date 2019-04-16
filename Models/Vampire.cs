using System;

namespace monsters
{
    public class Vampire : Monster<Vampire>, ICombustable, ISilverHater
    {
        public void Burn (string attack)
        {
            if (attack == "Fire") {
                Console.WriteLine ("The vampire burns like an oily rag until it's dead.");
            }
        }

        public void Stab (string attack)
        {
            if (attack == "Silver") {
                Console.WriteLine ("The vampire bleeds black blood from the wound and dies.");
            }
        }

        public override string ToString()
        {
            return "Vampire";
        }
    }
}
