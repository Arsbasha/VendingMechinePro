using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace VendingMechine
{
    public class Box
    {
        const int cola_drink_price = 1;
        const double Cost_chip_price = 0.50;
        const double Costcandy_price = 0.65;
        public double Total { get; set; }

        public void mechine()
        {
            Total = 0;
        }

        public void DepositCoin(double money)
        {
            switch (money)
            {
                case (1):
                    Total += 1;
                    break;
                case (0.50):
                    Total += 0.50;
                    break;
                case (0.65):
                    Total += 0.65;
                    break;
                case (100):
                    Total += 100;
                    break;
                default:
                    Console.WriteLine("Your entry is Invalid.");
                    break;
            }
        }

        public void DisplayDrink()
        {
            Console.WriteLine("");
            Console.WriteLine("Cola");
            Console.WriteLine("Chips");
            Console.WriteLine("Candy");
            Console.WriteLine("");
            Console.WriteLine("Please select your product:");
            SelectDrinkn(Convert.ToChar(Console.ReadLine().ToUpper()));

        }
        public bool checkTotal()
        {
            if (Total >= drink_price)
            { return true; }
            else { return false; }
        }
        
        private void SelectDrinkn(char selection)
        {
            bool selected = false;
            while (!selected)
            {
                switch (selection)
                {
                    case 'C':
                        Console.WriteLine("Thanks for buying Cola.");
                        ReturnChange();
                        selected = true;
                        break;

                    case 'L':
                        Console.WriteLine("Thanks for buying Chips.");
                        selected = true;
                        ReturnChange();
                        break ;
                    case 'Y':
                        Console.WriteLine("Thanks for buying Candy.");
                        ReturnChange();
                        selected = true;
                        break;

                    default:
                        Console.WriteLine("InvalidThank you");
                        selection = Convert.ToChar(Console.ReadLine().ToUpper());
                        selected= false;
                        break;
                }
            }
        }
        private void ReturnChange()
        {
            if (Total > drink_price)
            {
                Console.WriteLine("Your change {0:Cola}",Total =drink_price);

            }
        }
     
    }

}