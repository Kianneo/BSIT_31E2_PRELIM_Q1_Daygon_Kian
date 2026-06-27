using TransportChallenge;

public class Helicopter : Vehicle, IFlyable, IDriveable
{
    public override string Move()
    {
        return "Flying in the sky.";
    }

    public void Fly()
    {
        Console.WriteLine("Flying...");
    }

    public void Drive()
    {
        Console.WriteLine("Driving...");
    }
}