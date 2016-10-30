//Write a program that, depending on the user’s choice, inputs an  int ,  double  or  string  variable. ◦ If the variable is  int  or  double , the program increases it by one.
// If the variable is a  string , the program appends  *  at the end.
//Print the result at the console. Use switch statement.

using System;
   class IntDoubleString
    {
        static void Main()
        {
          
            string number = Console.ReadLine();
            switch (number)
            {
                case "integer":
                    
                    int a = int.Parse(Console.ReadLine());
                    Console.WriteLine(a + 1);
                    break;
                case "real":
                   
                    double b = double.Parse(Console.ReadLine());
                    Console.WriteLine(b + 1);
                    break;
                case "text":
                    
                    string c = Console.ReadLine();
                    Console.WriteLine(c + "*");
                    break;
            }



        }

    }

