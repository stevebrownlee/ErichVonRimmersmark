using System;

namespace monsters
{
    public class Wight : Monster<Wight>, ISilverHater
    {
        public void Stab (string attack)
        {
            if (attack == "Silver") {
                Console.WriteLine($"* {attack} makes the wight fall apart in pieces.");
            } else {
                NoEffect(attack);
            }
        }
    }
}
