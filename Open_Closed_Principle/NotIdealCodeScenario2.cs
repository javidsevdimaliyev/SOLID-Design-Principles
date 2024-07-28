using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Open_Closed_Principle.NotIdealCodeScenario2
{
    internal class CarService
    {
        public double Calculate(BaseCar car)
        {
            if (car is MercedesBenz m)
                return m.TripKM * 2;
            else if (car is BMW)
                return car.TripKM * 1.5;
            else
                return car.TripKM * 1;
        }
    }

    public abstract class BaseCar
    {
        public int TripKM { get; set; }
    }

    public class BMW : BaseCar
    {
        public string BrandName { get; set; }
        public int MaxSpeed { get; set; }

    }

    public class MercedesBenz : BaseCar
    {
        public string MarkName { get; set; }
        public int TopSpeed { get; set; }

    }

}
