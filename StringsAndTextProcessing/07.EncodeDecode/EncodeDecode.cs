//Write a program that encodes and decodes a string using given encryption key (cipher).
// The key consists of a sequence of characters. 
// The encoding/decoding is done by performing XOR (exclusive or) operation over the first letter
// of the string with the first of the key, the second – with the second, etc. When the last key character is reached, the next is the first.

using System;
using System.Text;
   class EncodeDecode
    {
       static void Main()
       {
           Console.Write("Enter 1 if you want encrypt a text");
           Console.WriteLine();
           Console.Write("Enter 2 if you want decrypt a text");
           Console.WriteLine();
           int choice = int.Parse(Console.ReadLine());
           switch (choice)
           {
               case 1: Console.Write("Enter a text to encrypt:");
                   string text = Console.ReadLine();
                   Console.Write("Enter a cypher:");
                   string cypher = Console.ReadLine();
                   Console.WriteLine(Encrypt(text, cypher));
                   break;
               case 2: Console.Write("Enter a text to decrypt:");
                   string DecrText = Console.ReadLine();
                   Console.Write("Enter a cypher:");
                   string cypher1 = Console.ReadLine();
                   Console.WriteLine(Decrypt(DecrText, cypher1));
                   break;
               default: Console.WriteLine("Invalid choice");
                   break;
           }
       }
          static string Encrypt(string text,string cypher)
          {
              StringBuilder cryptedText = new StringBuilder();
              for (int i = 0; i < text.Length; i++)
              {
               cryptedText.Append((char)((int)(text[i])^(int)cypher[i%cypher.Length]));
              }
              return cryptedText.ToString();
          }
          static string Decrypt(string text, string cypher)
          {
              StringBuilder decryptedText = new StringBuilder();
              for (int i = 0; i < text.Length; i++)
              {
                  decryptedText.Append((char)((int)text[i] ^ (int)cypher[i % cypher.Length]));
              }
              return decryptedText.ToString();
          }

        } 
    

