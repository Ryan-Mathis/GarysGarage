namespace Garage;

public class Tesla : Vehicle  // Electric car
{
    public double BatteryKWh { get; set; }

    public void ChargeBattery()
    {
        // method definition omitted
    }

    public override void Drive()
    {
        Console.WriteLine($"The {MainColor} Telsa drives past. Brrrr!");
    }

    public override void Stop()
    {
        Console.WriteLine($"The {MainColor} Tesla quietly rolls to a halt.");
    }
}