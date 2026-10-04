using System;
using System.Numerics;
using System.Runtime.CompilerServices;

public class Driver : Person
{
    public string Vehicle{get;}
    public string Bio{get;}
    public bool NeedsGlasses{get;}

    public Driver(string name, string surname, int id, int qualification, string profilePhotoPath, string vehicle, string bio, bool needsGlasses)
                    : base(name, surname, id, qualification, profilePhotoPath)
    {
        this.Vehicle = vehicle;
        this.Bio = bio;
        this.NeedsGlasses = needsGlasses;
    }

    public virtual int GetMaxPassengers()
    {
        return 1;
    }
}