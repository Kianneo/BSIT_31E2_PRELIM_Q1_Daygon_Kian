using TransportChallenge;

public class Airplane : Vehicle, IFlyable
{
    public override string Move()
    {
        return "Flying in the sky.";
    }

    public void Fly()
    {
        Console.WriteLine("Flying...");
    }
}

