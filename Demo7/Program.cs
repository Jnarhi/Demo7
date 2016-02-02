using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo7
{
    class Program
    {
        static void Main(string[] args)
        {
            string line = null;
            StreamWriter outputFile = new StreamWriter(@"d:\T1Lines.txt");

            // kysytään rivit käyttäjältä
            do
            {
                Console.Write("Give a textline (enter stops): ");
                line = Console.ReadLine();
                outputFile.WriteLine(line); // kirjoittaa levylle syötetyt rivit
            } while (line.Length != 0);
            // suljetaan tiedosto
            outputFile.Close();

            // avaa tiedosto
            try {
                string text = File.ReadAllText(@"d:\T1Lines.txt");

                // näyttää sisällön
                Console.WriteLine("Contents of T1Lines.txt:\n" + text);
            } catch (FileNotFoundException)
            {
                Console.WriteLine("File not found!!!");
            }
            
        }
    }
}
