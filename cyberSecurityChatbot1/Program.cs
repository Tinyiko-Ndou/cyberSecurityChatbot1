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

            // 2 second delay before showing the welcome message
            Thread.Sleep(2000);

            Console.WriteLine("WELCOME TO THE CYBER SECURITY AWARENESS BOT !!!");
            Console.WriteLine();
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();


            Console.WriteLine("Welcome, " + name + "!!");

            while (true)
            {
                Console.Write("\nAsk me something (exit to Quit): ");
                string input = Console.ReadLine().ToLower();

                if (input == "exit")
                {
                    Console.WriteLine("Goodbye!!");
                    break;
                }
                Bot.Respond(input, name);
            }



        }
    }
}
