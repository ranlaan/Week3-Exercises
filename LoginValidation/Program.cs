using System;

namespace LoginValidation
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutajal sisestada kasutajatunnus ja parool
            //programm kontrollib sisestatud andmeid
            //kui sisestatud kasutaja on "admin" ja sisestatud parool on "admin1234"
            //siis programm kuvab "Tere tulemast"
            //muul juhulprogramm kuvab "Vale kasutajatunnus või parool. proovi uuesti"

            Console.WriteLine("sisesta oma kasutajatunnus");
            string kasutajatunnus = Console.ReadLine();
            Console.WriteLine("sisesta oma parool");
            string parool = Console.ReadLine();

            /*if (kasutajatunnus == "admin" && parool == "admin1234")
            {
                Console.WriteLine("Tere tulemast");
            }
            else
            {
                Console.WriteLine("Vale kasutajatunnus või parool. proovi uuesti");
            }*/
           
            if(kasutajatunnus != "admin" || parool != "admin1234")
            {
                Console.WriteLine("Vale kasutajatunnus või parool. proovi uuesti");
            }
            else
            {
                Console.WriteLine("tere tulemast!");
            }
            



        }
    }
}
