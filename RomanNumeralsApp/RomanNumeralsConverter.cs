using System;
namespace RomanNumeralsApp
{
	public class RomanNumeralsConverter
	{
        string userInput;
        string userInputFormatted;
        bool validInput = false;

        Dictionary<string, int> RomanNumerals = new Dictionary<string, int>()
       {
                { "I", 1 },
                 { "II", 2},
                 {"III" , 3 },
                 { "IV", 4 },
                 {"V" , 5 },
                 { "VI", 6 },
                 { "VII", 7 },
                 { "VIII", 8 },
                 { "IX", 9 },
                 { "X", 10 }
        };
        // Method for converting roman numerals into numbers

        public string GetUserInput()
        {
            do
            {
                Console.WriteLine("Please enter a Roman Numeral between I and X ?");
                userInput = Console.ReadLine();
                userInputFormatted = userInput.ToUpper();
                if (String.IsNullOrEmpty(userInputFormatted))
                {
                    Console.WriteLine("User input cannot be null or empty");
                }
                else if (RomanNumerals.ContainsKey(userInputFormatted))
                {
                    validInput = true;
                }
                else
                {
                    Console.WriteLine("User input is not a roman numeral with limitations of I - X");
                }


            }
            while (validInput == false);
            return userInputFormatted;

        }
        public int ConvertRomanNumerals(string userInputFormatted)
        {
            
            Console.WriteLine(RomanNumerals[key: userInputFormatted]);
            return RomanNumerals[key: userInputFormatted];

        }


        public RomanNumeralsConverter()
		{
		}
	}
}

