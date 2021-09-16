using System;

namespace InstagramAgeValidation
{
    class Program
    {
        static void Main(string[] args)
        {
            //Programm küsib kasutaja sünniaastat
            //programm arvutab kasutaja vanust
            //programm koontrollib, kas kasutaja on vanem kui 13 või noorem kui 13
            //kui kasutaja oon 13 aastat või vanem siis võib ta instagrami kasutada
            //kui kasutaja on noorem kui 13 siis ta on liiga noor 

            Console.WriteLine("Sisesta oma sünniaasta");
            int YearOfBirth = Convert.ToInt32(Console.ReadLine());
            int Age = 2021 - YearOfBirth;

            if (Age >= 13)
            {
                Console.WriteLine($"Oled {Age} aastat vana, saad teha instagrami kasutaja");
            }
            else  
            {
                Console.WriteLine($"Oled {Age} aastat vana, sa ei saa teha instagrami kasutajat");
            }
           




        }
    }
}
