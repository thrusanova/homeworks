//Classical play cards use the following signs to designate the card face: `2, 3, 4, 5, 6, 7, 8, 9, 10, J, Q, K and A.
//Write a program that enters a string and prints “yes” if it is a valid card sign or “no” otherwise. Examples:
using System; 
class CheckPlayCard
    {
        static void Main()
        {
            
            string card = Console.ReadLine();
            if ((card == "2") || (card == "3") || (card == "4") || (card == "5") || (card == "6") || (card == "7") ||
                (card == "8") || (card == "9") || (card == "10") || (card == "A") || (card == "Q") || (card == "J") || (card == "K"))
            {
                Console.WriteLine("yes {0}",card);
            }
            else 
            {
                Console.WriteLine("no {0}",card);
            }

        }
    }

