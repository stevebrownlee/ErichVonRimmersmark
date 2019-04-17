using System;

namespace monsters
{
    public class Mummy : Monster<Mummy>, ICombustable
    {
        public void Burn (string attack)
        {
            if (attack == "Fire") {
                Console.WriteLine($"{attack} makes the mummy light up like a torch until it's a charred ball.");
            }
        }
    }

}
