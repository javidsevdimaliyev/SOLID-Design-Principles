namespace Open_Closed_Principle.IdealCodeScenario2
{
    internal class CarService
    {
        public double Calculate(BaseCar car)
        {
            return car.TripKM * car.GetCostPerKM();
        }
    }

    public abstract class BaseCar
    {
        public int TripKM { get; set; }

        public abstract double GetCostPerKM();
    }

    public class BMW : BaseCar
    {
        public string BrandName  { get; set; }  
        public int MaxSpeed  { get; set; }  
        public override double GetCostPerKM()
        {
            return 1.5;
        }

    }

    public class MercedesBenz : BaseCar
    {
        public string MarkName { get; set; }
        public int TopSpeed { get; set; }
        public override double GetCostPerKM()
        {
            return 2;
        }
    }

    public class Toyota : BaseCar
    {
        public override double GetCostPerKM()
        {
            return 0.75;
        }
    }
}
