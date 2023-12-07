using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace BreakOutRoom_mopifikatoryPristupu
{
    internal class Koule : Teleso
    {
        private double Radius;
        private const double PiNumber = Math.PI;

        protected override void NacteniOdUzivatele()
        {
            Console.WriteLine("Zadej radius koule");
            double.TryParse(Console.ReadLine(), out Radius);
        }

        protected override double Objem()
        {
            return 4 / 3 * PiNumber * Math.Pow(Radius, 3);
        }

        protected override double VypocitejPovrch()
        {
            return 4 * PiNumber * Math.Pow(Radius, 2);
        }

        public override string ToStirng()
        {
            NacteniOdUzivatele();
            Objem();
            VypocitejPovrch();
            return $"Koule s radiusem{Radius} ma objem {Objem()} mm3 a povrch {VypocitejPovrch()} mm2.";
        }
    }
}
