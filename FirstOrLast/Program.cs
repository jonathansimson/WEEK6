﻿using System;

namespace FirstOrLast
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutajal sisestada ees- ja perekonnanime
            //programm kontrollib andmete pikkust eraldi
            //programm kuvab, kumb nendest on pikem, kas ees- või perekonnanimi

            Console.WriteLine("Sisesta eesnimi:");
            string firstName = Console.ReadLine();
            Console.WriteLine("Sisesta perekonnanimi:");
            string lastName = Console.ReadLine();

            if (firstName.Length > lastName.Length)
            {
                Console.WriteLine($"Sinu eesnimes on rohkem sümboleid, kui perekonnanimes.({firstName.Length})");
            }
            else if (firstName.Length < lastName.Length)
            {
                Console.WriteLine($"Sinu perekonnanimes on rohkem sümboleid, kui eesnimes.({lastName.Length})");
            }
            else
            {
                Console.WriteLine($"Sinu eesnimes ja perekonnanimes on sama arv sümboleid.({lastName.Length})");
            }
        }
    }
}
