using System;

namespace ConsoleApp5
{
    class Program
    {
        
        static void Main(string[] args)
        {

            Console.WriteLine(Man.GetNumber());
            
            var test = new Man(66);
            
            var ivan = new Man("Ivan", 10, 140, 40, Color.Black);
            
            var ivane1 = new Man("dsfgsdfg", 10);
            
            var ivan2 = new Man("Ivan", 10, 140, 40, Color.Black, Color.Red);
            
            var petr = new Man("Petr", 30, new Car(2023, Car.CarColor.Black, 0));
            
            Console.WriteLine(ivan.Car);
            
            ivan.HairColor = Color.Black;
            //
            //
            // Console.WriteLine(ivan.HairColor);

            // Console.WriteLine(ivan.Rank);
            // Console.WriteLine(ivan.CalculateRank());
            // Console.WriteLine("----");
            //
            // ivan.Weight += 9;
            //
            // Console.WriteLine(ivan.Rank);
            // Console.WriteLine(ivan.CalculateRank());




            // ivan.Age = 99;

            // var ivan1 = new Man("Ivan", 10, 140, 40, Color.Black);
            // var ivan2 = new Man("Ivan", 10, 140,40, Color.Black);
            // var ivan3 = new Man("Ivan", 10, 140, 40, Color.Black);
            // var ivan4 = new Man("Ivan", 10, 140, 40, Color.Black);
            //
            //
            // Console.WriteLine(Man.GetNumber());


            // Car car = new Car(2010, Car.CarColor.Black, 10000);
            //
            //
            // Console.WriteLine(car.GetCarYear());
            // Console.WriteLine(car.GetMileage());
            //
            // Console.WriteLine($"1. {car}");
            //
            // car.GoOneMile();
            // car.GoOneMile();
            // car.GoOneMile();
            //
            // Console.WriteLine(car.GetMileage());
            //
            // Console.WriteLine(car.GetCarYear());
            //
            // Console.WriteLine($"2. {car}");



        }

    }
}