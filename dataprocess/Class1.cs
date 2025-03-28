using System;
using System.Collections.Generic;

namespace ClassLibrary1
{
    public static class DATAPROCESSING  
    {
        private static List<string> guests = new List<string>();

        public static void RegisterGuest(string guestName)
        {
            if (!string.IsNullOrWhiteSpace(guestName))
            {
                guests.Add(guestName);
            }
        }

        public static List<string> GetGuestList()
        {
            return new List<string>(guests);
        }

        public static bool RemoveGuest(string name)
        {
            return guests.Remove(name);
        }
    }
}
