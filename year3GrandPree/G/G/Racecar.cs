using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G
{
    public class Racecar
    {
        public Engine Engine { get; set; }
        public String colour { get; set; }
        public String model { get; set; }
        public int NumWheels { get; set; }
        public String make { get; set; }
        public int DistanceTravelled { get; set; }

        public Racecar()
        {
            this.DistanceTravelled = 0;

        }

        public Engine engine { get; set; }
        

        

        public void move(int meters)
        {
            if (this.Engine.EngineOn)
            {
                this.DistanceTravelled += meters;
            }
        }
        

        

    }
}
