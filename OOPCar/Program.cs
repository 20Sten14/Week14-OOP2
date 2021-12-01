using System;

namespace OOP_Part1
{
    class Program
    {
        class Car
        {
            string mark;
            string model;
            string regNum;
            string color;
            int odometer;
            int fuel;

            public Car(string _mark, string _model, string _regNum, string _color)
            {
                mark = _mark;
                model = _model;
                regNum = _regNum;
                color = _color;
                odometer = 0;
                fuel = 20;

                Console.WriteLine($"you've made your {_mark} and model {_model}");
            }
            /*public double Weight
            {
                get { return w; }
            }*/
            public void ShowCarInfo()
            {
                Console.WriteLine("");
                Console.WriteLine($"Cars name: {mark}");
                Console.WriteLine($"Cars Model:{model}");
                Console.WriteLine($"Cars regNum: {regNum}");
                Console.WriteLine($"Cars color: {color}");
                Console.WriteLine($"Car's odometer: {odometer}");
                Console.WriteLine($"Car's fuel level: {fuel}");

            }
            public string Model
            {
                get { return model; }
            }
            public string Mark
            {
                get { return mark; } 
            }
            public string RegNum
            {
                get { return regNum; }
            }
            public string Color
            {
                get { return color; }
            }
            public int Odometer
            {
                get { return odometer; }
            }
            public int Fuel
            {
                get { return fuel; }
            }
            public void drive()
            {
                fuel -= 5;
                odometer += 80;
                Console.WriteLine("Zoom zoom");
            }
           static void Main(string[] args)
           {
                Car newcar = new Car("Subaru", "Legacy", " 871BJH", "Black");
                
                while (newcar.Fuel > 0) 
                {
                    
                  newcar.drive();
                  Console.WriteLine($"Fuel after drive: {newcar.Fuel}");
                    
                }
                newcar.ShowCarInfo();
           }



        }
    }
}