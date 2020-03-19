using System;
using System.Text.RegularExpressions;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            // Strings

            // do this - use lowercase string
            string name = "James";

            // don't do this - no cases, ever
            String taName = "Darion";

            // string concat - "James Darion"
            string bothTeachers = name + " " + taName;
            string alternateBothTeachers = string.Concat(name, " ", taName);
            //                             "James Darion"
            string interpolatedTeachers = $"{name} {taName}";

            // Strings are immuntable, which means you CANNOT change the internal
            // values of the string as shown below.
            // interpolatedTeachers[2] = 's';

            char[] letters = new[] { 'a', 'b', 'c' };

            string word = new string(letters);

            // comparing strings
            string userInput = "Y";

            if (string.Equals(userInput, "y", StringComparison.OrdinalIgnoreCase))
            {
                // some shit
            }

            if (userInput.Equals("y", StringComparison.OrdinalIgnoreCase))
            {
                // some shit
            }

            // IndexOf 

            string multiTeachers = "James Darion Darion Darion";
            //                              0123456789...
            //                             "James Darion"
            int firstIndexOfDarion = multiTeachers.IndexOf("Darion");
            int lastIndexOfDarion = multiTeachers.LastIndexOf("Darion");
            bool isDarionSuffix = multiTeachers.EndsWith("Darion ");

            // Replace
            string multiTeacherReplaceLetterAWIthLetterU = multiTeachers.Replace("a", "u");
            string replaceDarionWithJames = multiTeachers.Replace("Darion", "James", StringComparison.OrdinalIgnoreCase);

            // split 
            //       {"James", "Darion", "Darion", "Darion"}
            string[] teachers = multiTeachers.Split(' ');

            // split and trim
            string multiTeacherWhiteSpaces = "      James Darion Darion Darion      ";
            string multiTeacherSansWhiteSPace = multiTeacherWhiteSpaces.Trim();
            string[] multTeachersSplitSansWhiteSpace = multiTeacherSansWhiteSPace.Split(' ');

            // split example
            string excelExport = "name,age,location,thing";
            string[] seperatedValues = excelExport.Split(',');

            string facebookDotCom = "www.face-book.com";
            string[] domainSplit = facebookDotCom.Split('.');
            string websiteName = domainSplit[1];

            // string method chaining
            string middleUrlName = facebookDotCom.Split('.')[1].Split('-')[1];

            Console.WriteLine(facebookDotCom.Split('.'));

            for (int i = 0; i < domainSplit.Length; i++)
            {
                Console.WriteLine(domainSplit[i]);
            }

            // substring
            string wordWeAreLookingFor = "baby";
            string sentence = "I'm just a baby in a grownups world";
            int indexOfBaby = sentence.IndexOf(wordWeAreLookingFor);
            
            

            string baby = sentence.Substring(indexOfBaby, wordWeAreLookingFor.Length);

            string sentenceWithPhoneNumber = "sup, my phone number is 123-456-1234";

            int indexOfPhoneNumber = sentenceWithPhoneNumber.IndexOf("123-456-1234");

            string withoutPhoneNumber = sentenceWithPhoneNumber.Substring(0, indexOfPhoneNumber);





            string phoneNumber = sentenceWithPhoneNumber.Substring(indexOfPhoneNumber, 12);

            string[] individualNumbers = phoneNumber.Split('-');

            int areaCode = int.Parse(individualNumbers[0]);

            string cSharpEscape = @"sup  \dude\ ";

            // ReGEX match on phone numbers
            Regex pattern = new Regex(@"((https:\/\/)?(www\.)?\w*\.com)");

            string sentenceWithUrl = "Hey dude, have you ever been to www.reddit.com?";

            string sentenceWithoutUrl = "Hey dude, have you ever been to CedarPoint?";

            if (pattern.IsMatch(sentenceWithoutUrl))
            {
                Console.WriteLine("Of course I've been there!");
            } 
            else
            {
                Console.WriteLine("... no");
            }

            string grandCircusShoutout = pattern.Replace(sentenceWithUrl, "www.grandcircus.co");

        } 
    }
}
