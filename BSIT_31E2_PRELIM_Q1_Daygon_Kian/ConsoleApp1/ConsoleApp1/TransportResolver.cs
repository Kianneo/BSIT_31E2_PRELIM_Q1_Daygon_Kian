namespace TransportChallenge;

public static class TransportResolver
{
    public static Vehicle? Resolve(string transport)
    {
        transport = transport.ToLower();

        if (transport == "car")
        {
            return new Car();
        }
        else if (transport == "plane")
        {
            return new Airplane();
        }
        else if (transport == "boat")
        {
            return new Boat();
        }
        else if (transport == "helicopter")
        {
            return new Helicopter();
        }
        else
        {
            return null;
        }
    }
}