using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Obronca:Pilkarz
    {
        public Obronca(string imie, string nazwisko, int numerNaKoszulce)
        {
            try
            {
                if (numerNaKoszulce % 2 == 0)
                {
                    Console.WriteLine("Błędny numer");
                }
            }
            catch (Exception)
            {

            }
        }
        public override string ToString()
        {
            return String.Format("Obronca") + Environment.NewLine + String.Format("Imie i nazwisko {0} {1}", imie, nazwisko) + Environment.NewLine + String.Format("Numer na koszulce: {0}", numerNaKoszulce);
        }
    }
}
