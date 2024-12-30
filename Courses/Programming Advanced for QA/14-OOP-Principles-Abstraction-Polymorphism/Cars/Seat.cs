using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Cars
{
    public class Seat : ICar
    {
        public Seat(string model, string color)                 //Конструктор
        {
            Model = model;
            Color = color;
        }

        public string Model { get; set; }                       //Пропъртита
        public string Color { get; set; }

        public string Start()                                     //Метод Start
        {
            return "Engine start";
        }

        public string Stop()                                      //Метод Stop
        {
            return "Break!";
        }

        public override string ToString()                       //Overrride ToString
        {
            return $"{Color} {GetType().Name} {Model}{Environment.NewLine}" +
                $"{Start()}{Environment.NewLine}" +
                $"{Stop()}";
        }
    }
}
