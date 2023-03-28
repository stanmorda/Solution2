using System;

namespace ConsoleApp5
{
    public class Car
    {
        public enum CarColor
        {
            Blue, 
            Black,
            Red
        }

        private CarColor _color;
        private int _year;
        private double _mileage;

        public Car( int year, CarColor color, double mileage)
        {
            _color = color;
            _year = year;
            _mileage = mileage;
        }

        public void GoOneMile()
        {
            _mileage += 1;
        }
        
        public double GetMileage()
        {
            return _mileage;
        }

        public int GetCarYear()
        {
            return DateTime.Now.Year - _year;
        }

        public override string ToString()
        {
            return $"Color: {_color}, Year: {_year}, Mileage: {_mileage}";
        }
        
        
    }
}