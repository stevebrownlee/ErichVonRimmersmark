using System;

namespace monsters {
    public class Monster<T> {
        public void Squish (string attack) {
            if (attack == "Silly Putty") {
                Console.WriteLine ($"The {typeof(T).Name} flattens like a pancake under the power of the {attack}.");
            }
        }

    }
}