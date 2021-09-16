using System;

namespace AndExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //tingimused sisseastumiseks;
            //miinimum matemaatikaks 85 punkti;
            //miinimum keemias 90 punkti;
            //miinium bioloogias 95 punkti;
            //Programm küsib kasutaalt sisestada tema eksami punktid ja otsusstab kas kasutaja saab arstiks õppida

            Console.WriteLine("Sisesta oma eksami tulemused");
            Console.WriteLine("matemaatika");
            int matemaatika = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("keemia");
            int keemia = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("bioloogia");
            int bioloogia = Convert.ToInt32(Console.ReadLine());

            if (matemaatika > 84 && keemia > 89 && bioloogia > 94) 
            {
                Console.WriteLine("Saad arstiks minna õppima");
            }
            else
            {
                Console.WriteLine("Ei saa minnaarstiks õppima");
            }
             





        }
    }
}
