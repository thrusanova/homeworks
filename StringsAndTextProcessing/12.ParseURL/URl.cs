//Write a program that parses an URL address given in the format:  [protocol]://[server]/[resource]  
//d extracts from it the  [protocol] ,  [server]  and  [resource]  elements.
     using System; 
     class FormatNumber 
     { 
         static void Main(string[] args) 
         {
             string input = "http://telerikacademy.com/Courses/Courses/Details/212 ";
             int firstIndex = input.IndexOf(":");
             int secondIndex = input.IndexOf("telerik");
             int lastIndex = input.IndexOf("/",secondIndex);
             string protocol = input.Substring(0, firstIndex);
             Console.WriteLine("[protocol]={0}",protocol);
             string server = input.Substring(secondIndex,lastIndex-secondIndex);
             Console.WriteLine("[server]={0}", server);
             string resourse = input.Substring(lastIndex, input.Length - lastIndex);
             Console.WriteLine("[resource]={0}", resourse);
         } 
     } 
