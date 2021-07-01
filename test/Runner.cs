using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;


namespace test
{
    [Serializable]
    
    public class Runner
    {
        public string Name { get; set; }
        public int Age { get;  set; }
        private int weight;
        public int Weight
        {
            get
            {
                return weight;
            }
            set
            {
                if(value >= 60 && value <= 100)
                {
                    weight = value;
                }
            }
        }
        private float avrspeed; 
        public float AvrSpeed
        {
            get
            {
                return avrspeed;
            }
            set
            {
                if(value >= 12 && value <= 17)
                {
                    avrspeed = value;
                }
            }
        }
        private static int distance;
        static Runner ()
        {
            distance = 100;
        }
        public int Distance { get; }

        private bool isRelay = false;

        public Runner (string _name, int _age, int _weight, float _avrspeed)
        {
            Name = _name;
            Age = _age;
            Weight = _weight;
            AvrSpeed = _avrspeed;
        }
        public Runner ()
        {
            Distance = distance;
        }

        private float time; // секунды
        
        public float Time { get { return time; } }
        private float timeSet()
        {
            time = distance / AvrSpeed;
            return time;
        }
        public void Run()
        {
            this.isRelay = true;
            timeSet();
            Console.WriteLine($"Бегун {Name} побежал и прибежал, его среднняя скорость {AvrSpeed}. " +
                $"Расстояние {distance}, Время {time}");
        }
        public override string ToString()
        {
            return $"Name = {Name} --- Age = {Age} --- Weight = {Weight} --- AvrSpeed = {AvrSpeed}";
        }

    }
    
}
