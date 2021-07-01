using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace test
{
    public class Deserializer
    {
        public List<Runner> DeserializToList()
        {
            try
            {
                List<Runner> runnerQueue = new List<Runner>();
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Runner>));
                using (FileStream fs = new FileStream("Runner.xml", FileMode.Open))
                {
                    runnerQueue = (List<Runner>)xmlSerializer.Deserialize(fs);

                }
                Console.WriteLine("XML считан в список.");
                return runnerQueue;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return null;
            }
            
        }

    }
}
