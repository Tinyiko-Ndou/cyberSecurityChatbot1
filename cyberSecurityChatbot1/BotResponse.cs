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
            else if (input.Contains("What can I ask"))
            {
                Console.WriteLine("You can ask about Passwords, Phishing and Safe browsing");
                Console.WriteLine();

            }
            else if (input.Contains("passwords"))
            {
                Console.WriteLine("Use strong Passwords that include a mix of letters, numbers, and special characters." +
                    " Avoid using easily guessable information like birthdays or common words." +
                    " Consider using a password manager to generate and store complex passwords securely.");
                Console.WriteLine();
            }
            else if (input.Contains("phishing"))
            {
                Console.WriteLine("Be careful of fake emails asking you for your personal info" +
                    " and always verify the sender before clicking on any links or providing sensitive information." +
                    " Report any suspicious emails to your IT department or email provider.");
                Console.WriteLine();
            }
            else if (input.Contains("safe browsing"))
            {
                Console.WriteLine("Always check website URLs and avoid suspicious links" +
                    " Use secure connections (https) and keep your browser and software up to date." +
                    " Consider using a reputable antivirus program and enable firewalls for added protection.");
                Console.WriteLine();
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
