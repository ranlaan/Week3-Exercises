using System;

namespace VowelsAndConsonans
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm kasutajal sisestada tähte
            //programm kontrollib kas sisestatud täht on täishäälik või kaashäälik
            //kui sisestatud täht on täishäälik programm kuvab "täishäälik"
            //Kui sisestatud täht on kaashäälik programm kuvab "kaashäälik"
            //kasutame switchi

            //"mingi sõna" - switch
            //"a" - character ehk char

            Console.WriteLine("Sisesta täht:");
            char userCharacter = Convert.ToChar(Console.ReadLine().ToLower());

            
            switch (userCharacter)
            {
                case 'ä':
                    Console.WriteLine("täishäälik");
                    break;
                case 'e':
                    Console.WriteLine("täishäälik");
                    break;
                case 'i':
                    Console.WriteLine("täishäälik");
                    break;
                case 'o':
                    Console.WriteLine("täishäälik");
                    break;
                case 'u':
                    Console.WriteLine("täishäälik");
                    break;

                default:
                    Console.WriteLine("kaashäälik");
                    break;
            }




        }
    }
}
