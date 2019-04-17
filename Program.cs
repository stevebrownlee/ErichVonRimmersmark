using System;

namespace monsters {
    class Program {
        static void Main (string[] args) {
            Hunter VonRimmersmark = new Hunter ("Erich", "Von Rimmersmark");

            Mummy tuts = new Mummy ();
            Vampire dracula = new Vampire ();
            Demon legion = new Demon ();
            Demon beelzebub = new Demon ();
            Wight booly = new Wight ();
            Ghoul nightReaver = new Ghoul ();

            System.Console.WriteLine(@"
Regular Kills
********************************************
");
            VonRimmersmark.Ignite (tuts);
            VonRimmersmark.SplashWater (legion);
            VonRimmersmark.WieldSilverSword (booly);
            VonRimmersmark.WieldSilverSword (beelzebub);
            VonRimmersmark.Ignite (dracula);
            VonRimmersmark.SplashWater (nightReaver);

            System.Console.WriteLine(@"

Ultimate Kills
********************************************
");
            VonRimmersmark.ThrowSillyPutty<Demon> (legion);
            VonRimmersmark.ThrowSillyPutty<Vampire> (dracula);
            VonRimmersmark.ThrowSillyPutty<Mummy> (tuts);
            VonRimmersmark.ThrowSillyPutty<Wight> (booly);
            VonRimmersmark.ThrowSillyPutty<Ghoul> (nightReaver);

            System.Console.WriteLine("\n\n\n\n\n");
        }
    }
}
