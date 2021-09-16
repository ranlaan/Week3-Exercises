using System;

namespace Week3Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutajal sisestada pin koodi
            //programm võrdleb sisestadud pn koodi arvug 1234
            //kui sisestatud pin kood in 1234
            //programm kuvab konsoolis "Tere tulemast!"
            //kui sisestatud pin on vale, programm kuvab konsoolis "Vale pin, prrovi uuesti."

            Console.WriteLine("Sisesta PIN-kood");
            int pin = Convert.ToInt32(Console.ReadLine());

            /*if (pin == 1234)
            {
                Console.WriteLine("Tere tulemast!");
            }
            else
            {
                Console.WriteLine("Vale PIN, proovi uuesti.");
            }*/
            
            if(pin != 1234)
            {
                Console.WriteLine("Vale PIN, proovi uuesti.")
            }
            else
            {
                Console.WriteLine("Tere tulemast!");
            }
            





        }
    }
}
