using System;

namespace monsters {
    class Program {
        static void Main (string[] args) {
            Hunter VonRimmersmark = new Hunter ("Erich", "Von Rimmersmark");

            Mummy tuts = new Mummy ();
            Vampire dracula = new Vampire ();
            Demon legion = new Demon ();

            VonRimmersmark.Ignite (tuts);
            VonRimmersmark.Ignite (dracula);
            VonRimmersmark.SplashWater (legion);
//            VonRimmersmark.ThrowSillyPutty<Demon> (legion);
//            VonRimmersmark.ThrowSillyPutty<Vampire> (dracula);
        }
    }
}
