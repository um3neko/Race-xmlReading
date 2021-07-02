using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using test;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {

        [TestMethod] 
        public void CheckRunnersForRace()
        {
            Race race = new Race("race1", 500, 5);
            Deserializer deserializer = new Deserializer();
            List<Runner> runners = deserializer.DeserializToList();

            int expectedDistance = race.Distance;
            int actualDistance = 0;

            foreach (var e in runners)
            {
                actualDistance += e.Distance;
            }

            Assert.AreEqual(expectedDistance, actualDistance);
        }

        [TestMethod]
        public void CheckRunnersName()
        {
            Deserializer deserializer = new Deserializer();
            List<Runner> runners = new List<Runner>();
            runners = deserializer.DeserializToList();
            foreach (var e in runners)
            {
                Assert.IsNotNull(e.Name);
            }

        }
        [TestMethod]
        public void CheckRunnersAge()
        {
            int zero = 0;
            Deserializer deserializer = new Deserializer();
            List<Runner> runners = new List<Runner>();
            runners = deserializer.DeserializToList();
            foreach (var e in runners)
            {
                Assert.AreNotEqual(zero, e.Age);
            }
        }

    }
}
