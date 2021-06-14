using System;
using System.IO;
using System.Threading;

namespace RuneImageCollector
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Rune image collector initiated!");
            while (true)
            {
                var path = Directory.GetCurrentDirectory();                
                var runeImage = Directory.GetFiles(path, "2.png", SearchOption.TopDirectoryOnly);
                if (runeImage.Length > 0)
                {
                    int count = Directory.GetFiles(path, "*", SearchOption.TopDirectoryOnly).Length;                    
                    File.Move("2.png", "b_" + count + ".png");
                    Console.WriteLine($"New rune image found, saved as {count}.png");
                }                
                Thread.Sleep(5000);
            }           
        }
    }
}
