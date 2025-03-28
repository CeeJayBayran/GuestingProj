using System;
using System.Xml;
using ClassLibrary1;  

namespace GuestManagerApp
{
    internal class Program
    {
        static void Main() 
        {
            Console.WriteLine("Welcome Ma'am, Sir!");

            while (true)
            {
                DisplayActions();
                int userInput = GetUserInput();

                switch (userInput)
                {
                    case 1:
                        RegisterGuestUI();
                        break;
                    case 2:
                        ViewGuestsUI();
                        break;
                    case 3:
                        RemoveGuestUI();
                        break;
                    case 4:
                        Exit();
                        return;
                    default:
                        Console.WriteLine("Invalid option. Please try again.");
                        break;
                }
            }
        }

        static void DisplayActions()
        {
            Console.WriteLine("-------------------");
            Console.WriteLine("GUEST MANAGER MENU");
            Console.WriteLine("[1] Register Guest");
            Console.WriteLine("[2] View Guest List");
            Console.WriteLine("[3] Remove Guest");
            Console.WriteLine("[4] Exit");
        }

        static int GetUserInput()
        {
            Console.Write("Enter Action: ");
            if (int.TryParse(Console.ReadLine(), out int userInput))
            {
                return userInput;
            }
            return 0;
        }

        static void RegisterGuestUI()
        {
            Console.Write("Enter guest name: ");
            string guestName = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(guestName))
            {
                DATAPROCESSING.RegisterGuest(guestName);
                Console.WriteLine("Guest successfully registered! Welcome!");
            }
            else
            {
                Console.WriteLine("Invalid name. Please try again.");
            }
        }

        static void ViewGuestsUI()
        {
            var guests = DATAPROCESSING.GetGuestList();
            Console.WriteLine("List of Guests:");
            if (guests.Count == 0)
            {
                Console.WriteLine("No guests registered yet.");
            }
            else
            {
                foreach (var guest in guests)
                {
                    Console.WriteLine(guest);
                }
            }
        }

        static void RemoveGuestUI()
        {
            Console.Write("Enter guest name to remove: ");
            string nameToRemove = Console.ReadLine();
            if (DATAPROCESSING.RemoveGuest(nameToRemove))
            {
                Console.WriteLine("Guest removed successfully.");
            }
            else
            {
                Console.WriteLine("Guest not found.");
            }
        }

        static void Exit()
        {
            Console.Write("Enter your name to confirm exit: ");
            string userName = Console.ReadLine();

            if (!string.IsNullOrWhiteSpace(userName))
            {
                Console.WriteLine($"Thank you, {userName}. Have a great day!");
            }
            else
            {
                Console.WriteLine("Exiting without confirmation.");
            }
        }
    }
}
