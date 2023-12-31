namespace Garage;

public class Cessna : Vehicle // Propellor light aircraft
{
    public double FuelCapacity { get; set; }

    public void RefuelTank()
    {
        // method definition omitted
    }

    public override void Drive()
    {
        Console.WriteLine($"The {MainColor} Cessna drives past. Zoooooom!");
    }

    public override void Turn(string direction)
    {
        Console.WriteLine($"The {MainColor} Cessna arcs hard {direction}.");
    }

    public override void Stop()
    {
        Console.WriteLine($"The {MainColor} Cessna rolls to a stop ater rolling a mile down the runway.");
    }
}