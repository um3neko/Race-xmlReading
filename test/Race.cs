using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    public class Race
    {
        
        private static int idRace;
        public int IdRace { get; set; }
        private static int IdRaceInc()
        {
            idRace++;
            return idRace;
        }
        static Race ()
        {
            idRace = 0;
        }
        public Race(string _name, int _distance,int _countOfRunners)
        {
            IdRace = IdRaceInc();
            NameOf = _name;
            Distance = _distance;
            CountOfRunners = _countOfRunners;
        }

        public string NameOf { get; set; }
        public int Distance { get; set; }
        public int CountOfRunners { get; set; }
        public float TeamTime { get; private set; }
        public void Start(List<Runner> runners)
        {
            if (CountOfRunners == runners.Count)
            {
                int d = runners.Count * 100;
                if(d == Distance)
                {
                    foreach (var e in runners)
                    {
                        e.Run();
                        TeamTime += e.Time;
                        
                    }
                    Console.WriteLine($"Время забега {TeamTime}");
                }
                else Console.WriteLine("Ошибка в дистанции. Каждый участник пробегает 100м. Сумма дистанций участников != дистанции.");
                
            }
            else
                Console.WriteLine("Ошибка в дистанции. Каждый участник пробегает 100м. Сумма дистанций участников != дистанции.");
        }
        public override string ToString()
        {
            return $"id = {Race.idRace} --- Название {NameOf} --- Дистанция {Distance} --- Кол-во участников {CountOfRunners}";
        }
    }
}
