using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringFunctionsTutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            //    string name = "Lilian";
            //    string quote = "The man said, \\\"Hello\", Jesse. \n Hello on a new line. \n \t Hello on a tab."; // \\ double makes the \ show up
            //    string fileName = @"C:\Users\Jesse"; // the @ key basically says that the \ key is not an escape key and is a part of the string

            //    bool trueOrFalse = name.Contains("l"); //true
            //    trueOrFalse = name.EndsWith("i"); //false

            //    int length = name.Length;

            //    name = name.ToUpper(); // uppercase & name.ToLower(); = lowercase

            //    Console.WriteLine(quote);
            //    Console.WriteLine(fileName);
            //    Console.WriteLine(trueOrFalse);
            //    Console.WriteLine(length);
            //    Console.WriteLine(name);
            //    Console.ReadLine();

            //string name = "Lilian";
            //name = "Wendy";

            //StringBuilder sb = new StringBuilder();

            //sb.Append("My name is Lilian");

            //Console.WriteLine(sb);
            //Console.ReadLine();


            // Strings Assignment

            string firstName = "Lilian";
            string middleName = "Kim";
            string lastName = "Tan";

            // concatenates three strings
            string fullName = firstName + " " + middleName + " " + lastName;
            Console.WriteLine(fullName);

            // converts string to uppercase
            fullName = fullName.ToUpper();
            Console.WriteLine(fullName);

            // creates a stringbuilder and builds a paragraph of text, one sentence at a time
            StringBuilder sb = new StringBuilder();
            sb.Append("Today is Wednesday evening, ");
            sb.Append("I'm quietly doing my homework");
            sb.Append(". I wonder what the next course awaits.");
            sb.AppendLine();
            sb.Append("Looking forward to it.");
            Console.WriteLine(sb);

            Console.ReadLine();
        }
    }
}
