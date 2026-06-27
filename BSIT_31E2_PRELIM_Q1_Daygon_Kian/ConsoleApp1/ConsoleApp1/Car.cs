using TransportChallenge;

public class Car : Vehicle, IDriveable
{
    public override string Move()
    {
        return "Driving on the road.";
    }

    public void Drive()
    {
        Console.WriteLine("Driving...");
    }
}