using System;

namespace ConsoleApp5
{
    public class Man
    {
        private readonly string _name;
        private byte _age = 77;
        private int _height;
        private int _weight;
        private bool? _hasChildren;
        private Color _eyeColor;
        private Car _car;

        private int? _temp;

        private static int _number;
        public static int GetNumber()
        {
            return _number;
        }

        public Man(byte age)
        {
            _age = age;
        }
        
        public Man(string name, byte age = 0)
        {
            _name = name;
           
            _age = age;
        }
        
        public Man(string name, byte age, Car car) : this(name, age)
        {
            _car = car;
        }
        
        public Man(string name, byte age, int height, int weight, Color eyeColor = Color.Unknown) 
            :this(name, age)
        {
            bool check = Check(age, height, weight);
            if (!check)
            {
                throw new Exception("Некорректные данные");
            }

            _number++;
            
           
            _height = height;
            _weight = weight;
            _eyeColor = eyeColor;
        }

        public Man(string name, byte age, int height, int weight, Color eyeColor, Color hairColor) 
            : this(name, age, height, weight, eyeColor)
        {
            HairColor = hairColor;
        }

        public string Name => _name;

        public byte Age => _age;
        public Color EyeColor => _eyeColor;

        public Car Car => _car;

        private bool SameColor => HairColor == _eyeColor;
        
        public Color HairColor { get; set; }

        public int Weight
        {
            get
            {
                return _weight;
            }
            set
            {
                if (value > 0)
                    _weight = value;
            }
        }
        
        
        public double Rank
        {
            get
            {
                var rank = (_height + _weight / 10.0) / _age;
                if (SameColor)
                    rank += 1;
                
                return rank;
            }
        }
        
        
        public double CalculateRank()
        {
            return (_height + _weight / 10.0) / _age;
        }
        
        private bool Check(byte age, int height, int weight)
        {
            if (age > 120)
                return false;

            if (height > 300)
                return false;

            if (weight <= 0)
                return false;

            return true;
        }

        public string Print()
        {
            return $"{_name}: {_age}лет";
        }
        
        


    }
    
    public enum Color
    {
        Blue, 
        Black,
        Red,
        Unknown
    }
    
    public enum State
    {
        True, 
        False,
        Unknown
    }

    public class Test
    {
        public string T { get; set; }
        public string T1 { get; set; }
        public string T2 { get; set; }
        public string T3 { get; set; }
        public string T4 { get; set; }
    }
    
}