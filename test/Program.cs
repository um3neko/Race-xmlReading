using System;
using System.Configuration;
using System.Collections.Generic;
using System.Xml;
using System.Xml.Serialization;
using System.IO;
using System.Runtime.Serialization;


namespace test
{
    class Program 
    {
        static void Main(string[] args)
        {
            Deserializer deserializer = new Deserializer();
            List<Runner> runners = deserializer.DeserializToList();
            Console.WriteLine();
            foreach (var e in runners)
            {
                Console.WriteLine(e.ToString());
            }
            Console.WriteLine("----");

            Race race = new Race("race1", 500, 5);

            Console.WriteLine(race.ToString());

            race.Start(runners);

            Console.ReadLine();
        }
    }
}
