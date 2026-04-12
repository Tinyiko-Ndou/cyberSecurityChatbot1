namespace cyberSecurityChatbot1
{
    using System;
    using System.Media;
    internal class Program
    {
        static void Main(string[] args)
        {
            PlayGreeting.Play();
            asciiArt.Show();
            Console.WriteLine("Welcome to the Cyber Security Awareness Bot!");
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();


            Console.WriteLine("Welcome, " + name + "!!");

            while (true)
            {
                Console.Write("\nHow can i assit you (exit to Quit): ");
                string input = Console.ReadLine().ToLower();

                if (input == "exit")
                {
                    Console.WriteLine("Goodbye!!");
                    break;
                }
               // Bot.Respond(input, name);
            }



        }
    }
}
