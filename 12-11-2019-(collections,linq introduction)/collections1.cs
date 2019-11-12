using System;
using System.Collections.Generic;
namespace CollectionsL
{
    public class CollectionsList
    {
        public static void Main()
        {
            var cars = new List<Car>();
            cars.Add(new Car(){name="Honda1", color="blue", speed=50});
            cars.Add(new Car(){name="Honda2", color="green", speed=20});
            cars.Add(new Car(){name="Honda3", color="blue", speed=60});
            cars.Add(new Car(){name="Scoda1", color="red", speed=60});
            cars.Add(new Car(){name="Scoda2", color="green", speed=70});

            cars.Sort();
            foreach (Car c in cars)
            {
                Console.Write(c.color+ " ");
                Console.Write(c.name+ " ");
                Console.Write(c.speed+ " ");
                Console.WriteLine();
            }
            Console.WriteLine(cars.Capacity);
			Console.WriteLine(cars.Count);
			cars.Clear();
			Console.WriteLine(cars.Count);
        }
    }
    public class Car : IComparable<Car>
    {
        public  string name;
        public  string color;
        public  int speed;

        public int CompareTo(Car other)
        {
            int compare = String.Compare(this.color, other.color);
            if (compare == 0)
            {
                compare = this.speed.CompareTo(other.speed);
                compare = - compare;
            }
            return compare;
        }
    }
}