//• A bank account has a holder name (first name, middle name and last name), available amount of money (balance), bank name, IBAN, 3 credit card numbers associated with the account.
//• Declare the variables needed to keep the information for a single bank account using the appropriate data types and descriptive names.
using System;
    class BankAccountData
    {
        static void Main()
        {
            string firstName = "Tanya";
            string middleName = "Yaneva";
            string lastName = "Hrusanova";
            decimal balanceOfTheAccount = 1567.45m;
            string bankName = "First Investment Bank";
            string IBANNumber = "BG12FINB211175670005";
            string creditCard1 = "32546";
            string creditCard2 = "37646";
            string creditCard3 = "75475";
            Console.WriteLine(firstName+" "+middleName+" "+lastName);
            Console.WriteLine(balanceOfTheAccount);
            Console.WriteLine(bankName);
            Console.WriteLine(IBANNumber);
            Console.WriteLine(creditCard1);
            Console.WriteLine(creditCard2);
            Console.WriteLine(creditCard3);
        }
    }

