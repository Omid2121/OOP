using System;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Entry[] entries = new Entry[]
            {
                new Entry("www.facebook.com", "FaceBook", "f"),
                new Entry("www.google.com", "Goggle", "g"),
                new Entry("www.youtube.com", "YouTube", "y")

            };

            Console.WriteLine("Write down the key!");
            Console.WriteLine("Options");

            foreach (Entry entry in entries)
            {
                Console.WriteLine("\t" + entry.key + "-" + entry.name);

            }

            Console.WriteLine("\nYour Option?");

            string input = Console.ReadLine().ToLower();
            bool foundEntry = false;

            foreach (Entry entry in entries)
            {
                if (input == entry.key.ToLower() || input == entry.name.ToLower())
                {
                    System.Diagnostics.Process.Start(@"c:\Program Files\Internet Explorer\iexplore.exe",entry.url);
                    foundEntry = true;
                    RestartApp();

                }
            }
            if (foundEntry == false)
            {
                Console.WriteLine("\nCan't find a valid entry. Try again?");
                Console.WriteLine("\ty - yes");
                Console.WriteLine("\nYour Option?");

                string choice = Console.ReadLine();

                if (choice == "y" || choice == "yes")
                {

                }
            }

            Console.Read();

        }

        static void RestartApp() 
        {
            Console.Clear();
            Main(null);
        }

    }

}
