using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    abstract class Pilkarz
    {
        protected string imie;
        protected string nazwisko;
        protected int numerNaKoszulce;
        public override string ToString()
        {
            return String.Format("imie i nazwisko {0} {1}", imie, nazwisko) + Environment.NewLine + String.Format("Numer na Koszulce: {0}", numerNaKoszulce);
        }
    }
}
