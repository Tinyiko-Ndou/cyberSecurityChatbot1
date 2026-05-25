using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cyberSecurityChatbot1
{
    internal class Sentiment
    {
        public static void DetectEmotion(string input)
        {
            if (input.Contains("worried") || input.Contains("scared"))
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("Its okay to feel worried. Cyber threats can happen to anyone. Remember to stay informed and take precautions.");
                Console.WriteLine("I will help you learn how to stay safe online.");
                Console.ResetColor();
                return;
            }
            else if (input.Contains("curious"))
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Curiosity is great. Learning cyber security helps protect you online.");
                Console.ResetColor();
                return;
            }
            else if (input.Contains("frustrated"))
            {
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("I understand that this can feel frustrating.");
                Console.WriteLine("Lets Solve it step by step.");
                Console.ResetColor();
                return;
            }
            
        }
    }
}