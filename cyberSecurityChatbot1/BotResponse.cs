using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cyberSecurityChatbot1
{
    internal class Bot
    {
        public static void Respond(string input, string name)
        {
            // Sentiment Detection
            Sentiment.DetectEmotion(input);
            return;

            if (input.Contains("how are you"))
            {
                Console.WriteLine("Im functioning perfectly, " + name + " Ready to keep you safe online.");
            }
            else if (input.Contains("purpose"))
            {
                Console.WriteLine("My purpose is to teach you about Cyber security and Online Safety");
                Console.WriteLine();
            }
            else if (input.Contains("what is cyber security"))
            {
                Console.WriteLine("Cyber security is the practice of protecting systems, networks, and programs from digital attacks." +
                    "These attacks are usually aimed at accessing, changing, or destroying sensitive information; extorting money from users; or interrupting normal business processes.");

            }
            else if (input.Contains("what can i ask"))
            {
                Console.WriteLine("You can ask about:");
                Console.WriteLine("- Passwords");
                Console.WriteLine("- Phishing");
                Console.WriteLine("- Safe browsing");
                Console.WriteLine("- Cyber security");
                Console.WriteLine("- And you can ask me to remember your favourite topic by asking 'remember' after asking about one of the topics above");

                Console.WriteLine();

            }
            else if (input.Contains("password"))
            {
                Memory.FavouriteTopic = "Passwords";

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(RandomResponses.GetPasswordTip());
                Console.ResetColor();
            }
            else if (input.Contains("phishing"))
            {
                Memory.FavouriteTopic = "phishing";

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(RandomResponses.GetPhishingTip());
                Console.ResetColor();
            }
            else if (input.Contains("safe browsing") || input.Contains("browsing"))
            {
                Memory.FavouriteTopic = "safe browsing";

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(RandomResponses.GetSafeBrowsingTip());
                Console.ResetColor();
            }
            else if (input.Contains("remember"))
            {
                Console.ForegroundColor = ConsoleColor.Cyan;

                if (Memory.FavouriteTopic != null)
                {
                    Console.WriteLine("You previously asked about " + Memory.FavouriteTopic);
                }
                else
                {
                    Console.WriteLine("I dont have anything in memory yet. Ask me about Passwords, Phishing or Safe browsing to create a memory.");
                }
                    Console.ResetColor();
            }
               
                

            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("I didnt quite understand that. Please ask about Passwords, Phishing or Safe browsing");
                Console.ResetColor();
            }
        }
    }
}
