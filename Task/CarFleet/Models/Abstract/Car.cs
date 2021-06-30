using System;

namespace Task
{
    public abstract class Car
    {
        public string NameOfCar { get; set; }

        public Car(string name)
        {
            NameOfCar = name;
        }

    }
}
