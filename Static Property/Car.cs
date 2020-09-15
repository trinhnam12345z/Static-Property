using System;
using System.Collections.Generic;
using System.Text;

namespace Static_Property
{
    public class Car
    {

        private string name;
        private string engine;
        public static int numberOfCars;
        public Car(string name, string engine)
        {
            this.name = name;
            this.engine = engine;
            numberOfCars++;
        }
        public void setName(string newName)
        {
            this.name = newName;
        }
        public string getName()
        {
            return name;
        }
        public string getEngine()
        {
            return engine;
        }
        public void setEngine(string newEngine)
        {
            this.engine = newEngine;
        }
    }
}
