using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicles
{
    class Car
    {
        public Car(string regNo, string make, string color)
        {
            RegNo = regNo;
            Make = make;
            Color = color;
        }

        public Car(string regNo, string make, string color, int mileage) 
            : this(regNo, make, color)
        {            
            Mileage = mileage;
        }

        public string RegNo { get; set; }
        public string Make { get; set; }
        public int Mileage { get; private set; }
        public string Owner { get; set; }

        private string color;
        public string Color
        {
            get { return color; }
            set {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    color = value;                    
                }   
            }
        }

        public void Drive(int distance) {
            Mileage += Math.Abs(distance);
        }

        // Getters and setters methods
        // not needed when we have properties
        public string GetColor()
        {
            return color;
        }
        public void SetColor(string c)
        {
            if (!string.IsNullOrWhiteSpace(c))
            {
                color = c;
            }
        }          
    }
}
