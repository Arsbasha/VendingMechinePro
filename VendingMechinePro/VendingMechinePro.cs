using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using VendingMechine;

[assembly: InternalsVisibleTo("UnitTests")]

namespace VendingMechinePro
{
   internal class ProgramVending
    {
      public static void Main(string[] args)
        {
            var drinkingMachine = new Box();

            while (!drinkingMachine.checkTotal())
            {
                Console.WriteLine("Enter the coins to get product");
                drinkingMachine.DepositCoin(Convert.ToInt32(Console.ReadLine()));

            }
            drinkingMachine.mechine();
            Console.ReadLine();
        }
    }
}
