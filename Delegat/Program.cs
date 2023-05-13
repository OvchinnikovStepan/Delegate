namespace Delegat
{

    public delegate void Bob(int r);
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

             


            public void WashAll(Bob bob)
            {
               for (int i = 0;i< garage.cars.Count;i++)
                {
                    bob(i);
                }
            }
        }
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car { mark = "Lada", numer = "55551" };
            Car car2 = new Car { mark = "Honda", numer = "12345" };
            Car car3 = new Car { mark = "Lamba", numer = "41242" };
            Garage garage = new Garage();
            garage.Add(car1);
            garage.Add(car2);
            garage.Add(car3);
            CarWash carWash = new CarWash(garage);
            carWash.Wash(1);
            Console.WriteLine();
            Bob bob=carWash.Wash;
            carWash.WashAll(bob);
            garage.Remove(car3);
            Console.WriteLine();
            carWash.WashAll(bob);
        }
    }
}
