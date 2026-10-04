using System.Collections.Generic;

public class Pool : Driver
{
    public int MaxPassengers;

    public Pool (string name, string surname, int id, int qualification, string profilePhotoPath, string vehicle,
                 string bio, bool needsGlasses, int maxPassengers)
                 : base(name, surname, id, qualification, profilePhotoPath, vehicle, bio, needsGlasses)
    {
        this.MaxPassengers = maxPassengers;
    }

    public override int GetMaxPassengers()
    {
        return this.MaxPassengers;
    }
}