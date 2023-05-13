namespace Delegat
{
   
        public class Car
        {
            public string numer { get; set; }
            public string mark { get; set; }
        }

        public class Garage 
        { 
            public List<Car> cars = new List<Car>();
            public void Add(Car car) { cars.Add(car); }
            public void Remove(Car car) { cars.Remove(car);}
        }
        public class CarWash
        {
            public Garage garage;
            public CarWash(Garage garage)
            {
                this.garage = garage;
            }
            public void Wash(int num)
            {
                Console.WriteLine("Помыли машину {0} {1}", garage.cars[num].mark, garage.cars[num].numer);
            }

             public delegate void Bob(int r);


            public void WashAll(Bob bob)
            {
               for (int i = 0;i< garage.cars.Count;i++)
                {
                    Wash(i);
                }
            }
        }
    internal class Program
    {
        static void Main(string[] args)
        {
           
        }
    }
}