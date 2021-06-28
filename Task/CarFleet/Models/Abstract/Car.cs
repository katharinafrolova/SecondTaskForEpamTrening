using System;

namespace Task
{
    public abstract class Car
    {
        public string Name { get; set; }

        public Car(string name)
        {
            Name = name;
        }

        public Car(string name, bool flag)
        {
        }

    }
}
