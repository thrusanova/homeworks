//• Write a program that generates and prints all possible cards from a standard deck of 52 cards (without the jokers).
//The cards should be printed using the classical notation (like 5 of spades, A of hearts, 9 of clubs; and K of diamonds).
//◦ The card faces should start from 2 to A.
//Print each card face in its four possible suits: clubs, diamonds, hearts and spades. Use 2 nested for-loops and a switch-case statement
//Write a program that generates and prints all possible cards from a standard deck of 52 cards (without the jokers). 
//The cards should be printed using the classical notation (like 5 of spades, A of hearts, 9 of clubs; and K of diamonds). /
//◦ The card faces should start from 2 to A.
//Print each card face in its four possible suits: clubs, diamonds, hearts and spades. Use 2 nested for-loops and a switch-case statement.

using System;
class PrintDeckOf52Cards
{
    static void Main()
    {
        int num = 0;
        string s = Console.ReadLine();
        if (int.TryParse(s, out num))
            for (int i = 0; i <= num; i++)
            {
                if ((i > 1) && (i < 11))
                {
                    Console.WriteLine(i + " of spades," + " " + i + " of clubs," + " " + i + " of hearts," + " " + i + " of diamonds" + " ");
                }
            }
        else
        {
            if (s == "A")
            {
                num = 14;
            }
            else if (s == "K")
            {
                num = 13;
            }
            else if (s == "D")
            {
                num = 12;
            }
            else
            {
                num = 11;
            }
            for (int i = 0; i <= num; i++)
            {
                if ((i > 1) && (i < 14))
                {
                    Console.WriteLine(i + " of spades," + " " + i + " of clubs," + " " + i + " of hearts," + " " + i + " of diamonds" + " ");
                }
                if (i == 11)
                {
                    Console.WriteLine("J" + " of spades," + " " + "J" + " of clubs," + " " + "J" + " of hearts," + " " + "J" + " of diamonds" + " ");
                }
                else if (i == 12)
                {
                    Console.WriteLine("D" + " of spades," + " " + "D" + " of clubs," + " " + "D" + " of hearts," + " " + "D" + " of diamonds" + " ");
                }
                else if (i == 13)
                {
                    Console.WriteLine("K" + " of spades," + " " + "K" + " of clubs," + " " + "K" + " of hearts," + " " + "K" + " of diamonds" + " ");
                }
                else
                {
                    Console.WriteLine("A" + " of spades," + " " + "A" + " of clubs," + " " + "A" + " of hearts," + " " + "A" + " of diamonds" + " ");
                }
                }
            }
        }
    }




