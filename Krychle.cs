using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BreakOutRoom_mopifikatoryPristupu
{
        internal class Krychle : Teleso
        {
            private double Strana;

        protected override void NacteniOdUzivatele()
        {
            Console.WriteLine("Zadejte delku strany v mm: ");
            double.TryParse(Console.ReadLine(), out Strana);
        }

        protected override double Objem()
        {
            return Strana * Strana * Strana;
        }

        protected override double VypocitejPovrch()
        {
            return 6 * Strana * Strana;
        }

        public override string ToStirng()
        {
            NacteniOdUzivatele();
            Objem();
            VypocitejPovrch();
            return $"Krychle o delce strany {Strana} ma objem {Objem()} mm3 a povrch {VypocitejPovrch()} mm2.";
        }
    }
    

}
