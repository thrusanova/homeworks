﻿//Declare two string variables and assign them with following value:  The "use" of quotations causes difficulties.  
//Do the above in two different ways - with and without using quoted strings.
//Print the variables to ensure that their value was correctly defined.

using System;
class QuotesInStrings
{
    static void Main()
    {
        string firstStr = "The \"use\" of quotations causes difficulties.";
        string secondStr = @"The ""use"" of quotations causes difficulties.";
        Console.WriteLine(firstStr);
        Console.WriteLine(secondStr);
    }
}


