using System;
using StringProcessingApp.Services;

namespace StringProcessingApp.Views
{
    public class StringView
    {
        private StringService service = new StringService();

        public void Run()
        {
            int choice;

            do
            {
                DisplayMenu();
                Console.Write("Choose option: ");
                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.Write("Enter text: ");
                        service.EnterText(Console.ReadLine());
                        break;

                    case 2:
                        Console.WriteLine("Current Text: " + service.GetCurrentText());
                        break;

                    case 3:
                        service.ToUpperCase();
                        break;

                    case 4:
                        service.ToLowerCase();
                        break;

                    case 5:
                        Console.WriteLine("Character Count: " + service.CountCharacters());
                        break;

                    case 6:
                        Console.Write("Enter word: ");
                        Console.WriteLine(service.ContainsWord(Console.ReadLine()) ? "Found." : "Not Found.");
                        break;

                    case 7:
                        Console.Write("Old word: ");
                        string oldWord = Console.ReadLine();
                        Console.Write("New word: ");
                        string newWord = Console.ReadLine();
                        service.ReplaceWord(oldWord, newWord);
                        break;

                    case 8:
                        Console.Write("Start index: ");
                        int start = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Length: ");
                        int length = Convert.ToInt32(Console.ReadLine());
                        service.ExtractSubstring(start, length);
                        break;

                    case 9:
                        service.TrimSpaces();
                        break;

                    case 10:
                        service.ResetText();
                        break;

                    case 11:
                        Console.WriteLine("Goodbye!");
                        break;
                }

                Console.WriteLine();

            } while (choice != 11);
        }

        private void DisplayMenu()
        {
            Console.WriteLine("===== STRING PROCESSING SYSTEM =====");
            Console.WriteLine("1. Enter Text");
            Console.WriteLine("2. View Current Text");
            Console.WriteLine("3. Convert to UPPERCASE");
            Console.WriteLine("4. Convert to lowercase");
            Console.WriteLine("5. Count Characters");
            Console.WriteLine("6. Check if Contains Word");
            Console.WriteLine("7. Replace Word");
            Console.WriteLine("8. Extract Substring");
            Console.WriteLine("9. Trim Spaces");
            Console.WriteLine("10. Reset Text");
            Console.WriteLine("11. Exit");
        }
    }
}
