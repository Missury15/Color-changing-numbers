using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ChangingColors
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Random random = new Random();

            string[] colors = { "DarkBlue", "DarkGreen", "DarkCyan", "DarkRed", "DarkMagenta", "DarkYellow", "Blue", "Green", "Cyan", "Red", "Magenta", "Yellow", };
            int randomNumber = random.Next(0, colors.Length);
            


            for (int i = 0; i <= 999999; i = i + 1) //range
            {
                int colorIndex = random.Next(0, colors.Length);
                string colorName = colors[colorIndex];
                //Console.Beep(); //You can enable beeping :D but if will count slower

                if (Enum.TryParse(colorName, true, out ConsoleColor parsedColor))
                {
                    Console.ForegroundColor = parsedColor;
                }

                /*if (i == 50)
                {
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine("Something will happen here");
                    Console.Beep();
                }*/

                Console.WriteLine(i);
                Thread.Sleep(10); //Wait



            }
        }
    }
}
