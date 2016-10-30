//A company has name, address, phone number, fax number, web site and manager. The manager has first name, last name, age and a phone number.
// Write a program that reads the information about a company and its manager and prints it back on the console.

using System;
    class CompanyInformation
    {
        static void Main()
        {
            Console.Write("Company name:");
            string companyName = Console.ReadLine();
            Console.Write("Company address:");
            string companyAddress = Console.ReadLine();
            Console.Write("Phone number:");
            string phoneNumber = Console.ReadLine();
            Console.Write("Fax number:");
            string faxNumber = Console.ReadLine();
            Console.Write("Web site:");
            string webSite = Console.ReadLine();
            Console.Write("Manager first name:");
            string ManagerFirstName = Console.ReadLine();
            Console.Write("Manager last name:");
            string ManagerLastName = Console.ReadLine();
            Console.Write("Manager age:");
            int  ManagerAge =int.Parse(Console.ReadLine());
            Console.Write("Manager phone:");
            string ManagerPhone = Console.ReadLine();
            Console.WriteLine("{0}",companyName);
            Console.WriteLine("{0}",companyAddress);
            Console.WriteLine("{0}",phoneNumber);
            Console.WriteLine("(no fax)");
             Console.WriteLine("{0}",webSite);
             Console.WriteLine("Manager: "+ManagerFirstName+" "+ManagerLastName+"(age: "+ManagerAge+", "+"tel. "+ManagerPhone+")");
        }
    }
