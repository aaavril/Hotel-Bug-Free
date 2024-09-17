namespace Library;

public class GuestGroup
{
    public int NumberOfGuests { get; set;}
    
    public int NightsToStay { get; set;}

    public GuestGroup(int numberOfGuests, int nightsToStay)
    {
        this.NightsToStay = nightsToStay;
        this.NumberOfGuests = numberOfGuests;
    }
}