namespace Garage;

public class Ram : Vehicle // Gas powered truck
{
    public double FuelCapacity { get; set; }

    public void RefuelTank()
    {
        // method definition omitted
    }

    public override void Drive()
    {
        Console.WriteLine($"The {MainColor} Ram drives past. Rumble!");
    }

    public override void Stop()
    {
        Console.WriteLine($"The {MainColor} Ram screeches as it slowly decelerates to a stop.");
    }
}