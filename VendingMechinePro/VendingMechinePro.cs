using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMechinePro
{
    internal class Class1
    {
        static void Main(string[] args)
        {
            var drinkingMachine = new VendingMechine();

            while (!drinkingMachine.checkTotal())
            {
                Console.WriteLine("Enter the coins to get product");
                drinkingMachine.DepositCoin(Convert.ToInt32(Console.ReadLine()));

            }
            drinkingMachine.DisplayDrinkSelection();
            Console.ReadLine();
        }
    }
}
