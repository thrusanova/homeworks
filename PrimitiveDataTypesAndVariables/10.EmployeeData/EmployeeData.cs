//A marketing company wants to keep record of its employees. Each record would have the following characteristics:
//First name
// Last name
//Age (0...100)
// Gender (m or f)
// Personal ID number (e.g. 8306112507)
// Unique employee number (27560000…27569999)
//Declare the variables needed to keep the information for a single employee using appropriate primitive data types. Use descriptive names. Print the data at the console.

using System;
    class EmployeeData
    {
        static void Main()
        {
            string firstName = "Tanya";
            string lastName = "Hrusanova";
            byte age = 33;
            bool isFemale = true;
            string PersonalIDNumber = "8105270000";
            long uniqueEmployeeNumber = 27560001;
            Console.Write(firstName);
            Console.WriteLine(" " + lastName);
            Console.WriteLine(age);
            if (isFemale == true)
            {
                Console.WriteLine("f");
            }
            Console.WriteLine(PersonalIDNumber);
            Console.WriteLine(uniqueEmployeeNumber);
        }
    }
