using System;


namespace AttendanceChecker
{
    internal class Attendance
    {
        static List<string> guests = new List<string>();
        static void Main()
        {
            Console.WriteLine("Welcome Ma'am, Sir!");
            int exitCode = 0;

            while (exitCode == 0)
            {
                Console.WriteLine("Pick among the corresponding actions");
                Console.WriteLine("[1] Register the Name of Guest");
                Console.WriteLine("[2] View the list of Names");
                Console.WriteLine("[3] Remove The Name");
                Console.WriteLine("[4] Exit");
                Console.Write("Enter Action: ");

                if (int.TryParse(Console.ReadLine(), out int userAction))
                {
                    switch (userAction)
                    {
                        case 1:
                            Console.Write("Enter guest name: ");
                            string guestName = Console.ReadLine();
                            if (!string.IsNullOrWhiteSpace(guestName))
                            {
                                guests.Add(guestName);
                                Console.WriteLine("You are in the list WELCOME!!.");
                            }
                            else
                            {
                                Console.WriteLine("You are not in the list. Please try again.");
                            }
                            break;

                        case 2:
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
                            break;

                        case 3:
                            Console.Write("Enter name to remove: ");
                            string nameToRemove = Console.ReadLine();
                            if (guests.Remove(nameToRemove))
                            {
                                Console.WriteLine("Guest removed successfully.");
                            }
                            else
                            {
                                Console.WriteLine("Guest not found.");
                            }
                            break;

                        case 4:
                            Console.WriteLine("Exiting...");
                            exitCode = 1;
                            break;

                        default:
                            Console.WriteLine("Invalid option. Please try again.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a number between 1 and 4.");
                }
            }
        }
    }
}
