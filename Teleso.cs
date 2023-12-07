using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BreakOutRoom_mopifikatoryPristupu
{
    public abstract class Teleso
    {
        protected abstract void NacteniOdUzivatele();

        protected abstract double Objem();

        protected abstract double VypocitejPovrch();

        public abstract string ToStirng();
    }
}
