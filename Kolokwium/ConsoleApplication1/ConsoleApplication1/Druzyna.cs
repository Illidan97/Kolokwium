using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Druzyna:IDruzyna
    {
        private Pilkarz[,] druzyna;
        private string nazwa;
        

        public void UstawNapastnika()
        {
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("{0}",druzyna[0, i]);
            } 
        }

        public void UstawObronce()
        {
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("{0}", druzyna[1, i]);
            }
        }

        public void UstawNazwe()
        {
            Console.WriteLine("{0}",nazwa);
        }

        public bool CzyOK()
        {
           if(druzyna != 0)
        {
            return true;
        }
            else return false;
        }
    }
}
