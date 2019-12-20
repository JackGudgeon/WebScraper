using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SimpleWebScraper
{
    class Program
    {
        static void Main(string[] args)
        {


        }

        #region Examples

        private static void RegEx()
        {
            MatchCollection matches = Regex.Matches("blah blah blah blah...This is my cat....blah blah blah", "This is my [a-z]at");

            foreach(var match in matches)
            {
                Console.WriteLine(match);
            }
        }
        private static void CallExamples()
        {
            CalculatorSingleResponsibility();
            DownloadGoogle();
            BuilderPatternExample();
        }
         
        private static void CalculatorSingleResponsibility()
        {
            SimpleCalculator simpleCalculator = new SimpleCalculator();
            Console.WriteLine("The sum is: " + simpleCalculator.Add(3, 1));
            Console.ReadLine();
        }

        private static void DownloadGoogle()
        {
            using (WebClient client = new WebClient())
            {
                string googleMainPage = client.DownloadString("https://www.google.co.uk");
                Console.WriteLine(googleMainPage);
                Console.ReadLine();
            }
        }

        private static void BuilderPatternExample()
        {
            Person person1 = new PersonBuilder().Build();

            Person person2 = new PersonBuilder().WithAge(40).Build();
        }
        #endregion
    }
}
