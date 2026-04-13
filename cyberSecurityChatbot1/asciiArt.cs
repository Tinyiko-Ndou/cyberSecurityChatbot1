using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cyberSecurityChatbot1
{
    internal class asciiArt
    {
        public static void Show()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(@"


                      ██████╗ ██╗   ██╗██████╗ ███████╗██████╗ 
                     ██╔════╝ ██║   ██║██╔══██╗██╔════╝██╔══██╗
                     ██║      ██║   ██║██████╔╝█████╗  ██████╔╝
                     ██║      ██║   ██║██╔══██╗██╔══╝  ██╔══██╗
                     ╚██████╗ ╚██████╔╝██║  ██║███████╗██║  ██║
                      ╚═════╝  ╚═════╝ ╚═╝  ╚═╝╚══════╝╚═╝  ╚═╝  
===============================================================================================================           
                          CYBERSECURITY AWARENESS BOT
===============================================================================================================                           

");

            

                    Console.ResetColor();
        }
    }
}
