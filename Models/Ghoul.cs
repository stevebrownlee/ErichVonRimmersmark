using System;

namespace monsters
{
    public class Ghoul : Monster<Ghoul>, ISilverHater, IUnholy
    {
        public void Douse(string attack)
        {
            if (attack == "Holy Water") {
                Console.WriteLine($"* {attack} makes the ghoul freeze and shatter.");
            } else {
                NoEffect(attack);
            }
        }

        public void Stab (string attack)
        {
            if (attack == "Silver") {
                Console.WriteLine($"* {attack} makes the ghoul shriek and then explode.");
            } else {
                NoEffect(attack);
            }
        }
    }
}
