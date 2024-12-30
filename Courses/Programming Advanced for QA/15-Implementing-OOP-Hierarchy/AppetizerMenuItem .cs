using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseOopHierarchy
{

    //Артикул от менюто - Предястие
    public class AppetizerMenuItem : MenuItem
    {
        //Inherited: Name, Description, Price

        //Constructor
        public AppetizerMenuItem(string name, string description, decimal price) : base(name, description, price)
        {

        }


        //ToString -> "Appetizer: {base.ToString()}"
        public override string ToString()
        {
            return $"Appetizer: " + base.ToString();
        }
    }
}
