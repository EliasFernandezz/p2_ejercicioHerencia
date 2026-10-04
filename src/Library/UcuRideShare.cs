using System.Collections.Generic;
using Ucu.Poo.Discord;
using Ucu.Poo.Cognitive;

public class UcuRideShare
{
    public List<Passenger> Passengers {get;}
    public List<Driver> Drivers{get;}

    public DiscordClient Discord{get;}

    public UcuRideShare(DiscordClient discord)
    {
        this.Passengers = new List<Passenger>();
        this.Drivers = new List<Driver>();
        this.Discord = discord;
    }

    public void AddPassenger(Passenger passenger, ulong channelId)
    {
        this.Passengers.Add(passenger);
        this.Discord.SendMessage(channelId, $"se agregó al pasajero {passenger.Name} {passenger.Surname}");
        this.Discord.SendImage(channelId, $"{passenger.ProfilePhotoPath}", $"{passenger.Name} {passenger.Surname} - {passenger.Id}");
    }
    public void AddDriver(Driver driver, ulong channelId)
    {
        this.Drivers.Add(driver);
        this.Discord.SendMessage(channelId, $"se agregó al conductor {driver.Name} {driver.Surname}");
        this.Discord.SendImage(channelId, $"{driver.ProfilePhotoPath}", $"{driver.Name} {driver.Surname} - {driver.Id}");
    }

}