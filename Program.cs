using System;
using System.Collections.Generic;

namespace GuestManager
{
    internal class Program
    {
        static List<string> guests = new List<string>();

        static void Main()
        {
            Console.WriteLine("Welcome Ma'am, Sir!");

            while (true)
            {// Viewing sections of the actions
                DisplayActions();
                int userInput = GetUserInput();

                switch (userInput)
                {
                    case 1:
                        RegisterGuest();
                        break;
                    case 2:
                        ViewGuests();
                        break;
                    case 3:
                        RemoveGuest();
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
        {//DISPLAY SECTION OF ACTIONS 
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
            {//TO CHECK FOR ANY ERROR OR UNEXPECTED ERROR
                return userInput;
            }
            return 0;
        }

        static void RegisterGuest()
        {
            Console.Write("Enter guest name: ");
            string guestName = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(guestName))
            {
                guests.Add(guestName);
                Console.WriteLine("Guest successfully registered! Welcome!");
            }//CONFRMATION UPPON ENTERIG FIRST REGISTERING
            else
            {
                Console.WriteLine("Invalid name. Please try again.");
            }
        }

        static void ViewGuests()
        {
            Console.WriteLine("List of Guests:");
            if (guests.Count == 0)
            {
                Console.WriteLine("No guests registered yet.");
            }//VIEWING SECTION
            else
            {
                foreach (var guest in guests)
                {
                    Console.WriteLine(guest);
                }
            }
        }

        static void RemoveGuest()
        {
            Console.Write("Enter guest name to remove: ");
            string nameToRemove = Console.ReadLine();
            if (guests.Remove(nameToRemove))
            {
                Console.WriteLine("Guest removed successfully.");
            }
            else
            {//REMOVING BEFORE LEAVING
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
