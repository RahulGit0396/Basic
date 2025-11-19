/*
    Print multiplication table (1-10)
    Find factorial
    Reverse a string
    Count vowels in a sentence
*/

class PractiseSet()
{
    void PrintTable()
    {
        Console.WriteLine("Please enter the number");
        var userInput = Console.ReadLine();
        try
        {
            int number = int.Parse(userInput);
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(number * i);
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
            return;
        }
    }
    void PrintFactorial()
    {
        Console.WriteLine("Please enter the number");
        var userInput = Console.ReadLine();
        try
        {
            int number = int.Parse(userInput);
            int result = 1;
            for (int i = 1; i <= number; i++)
            {
                result *= i;
            }
            Console.WriteLine(result);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
            return;
        }
    }
    void PrintReverseString() 
    {
        Console.WriteLine("Please enter the String");
        string userInput = Console.ReadLine();
        
        for (int i = userInput.Length -1 ; i >= 0; i--)
        {
            Console.Write(userInput[i]);
        }
        Console.WriteLine();
    }
    void PrintVowelCount() 
    {
        Console.WriteLine("Please enter the String");
        string userInput = Console.ReadLine();
        
        char ch;
        int count = 0;
        for (int i = 0; i < userInput.Length -1; i++)
        {
            ch = userInput[i];
            switch (Char.ToLower(ch))
            {
                case 'a':
                case 'e':
                case 'i':
                case 'o':
                case 'u':
                    count++;
                    break;
                default:
                    break;
            }
        }
        Console.WriteLine("No of vowel present is " + count);
    }
    public static void Main(String[] args)
    {
        while (true)
        {
            Console.WriteLine("Please Select the below option :");
            Console.WriteLine(" 1. Print multiplication table \n 2. Find factorial \n 3. Reverse a string \n 4. Count vowels in a sentence");
            var selectedOption = Console.ReadLine();
            PractiseSet obj = new PractiseSet();
            switch (selectedOption)
            {
                case "1":
                    obj.PrintTable();
                    break;
                case "2":
                    obj.PrintFactorial();
                    break;
                case "3":
                    obj.PrintReverseString();
                    break;
                case "4":
                    obj.PrintVowelCount();
                    break;
                default:
                    Console.WriteLine("Invalid Option selected");
                    break;

            }

            Console.WriteLine("Choose option to rerun (y/n): ");
            string input = Console.ReadLine();

            if (input == "n")
            {
                Console.WriteLine("Exiting...");
                return;     // closes Main() and program ends
            }

            Console.WriteLine("Running again...");
        }

    }
}