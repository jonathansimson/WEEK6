﻿using System;

namespace FortuneTeller
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm ennustab, mis kasutajaga homme juhtub (kasutame Random klassi)

            string[] predictions = { "win a million", "fall in love", "buy youtube premium", "join the dark side for cookies" };

            Random rnd = new Random();
            int fortune = rnd.Next(0, predictions.Length);

            Console.WriteLine($"Tomorrow you will {predictions[fortune]}.");
        }
    }
}
