namespace Library;

public class Room
{
    public int Number { get; set;}
    
    public int MaxGuests { get; private set;}
    
    public Room(int number, int maxGuests)
    {
        this.Number = number;
        this.MaxGuests = maxGuests;
    }
    
    public GuestGroup Guests { get; set; }

    public RoomBill Bill { get; private set; } = new RoomBill();

}

    public void Occupy(GuestGroup group)
    {
        this.Guests = group;
    }

    public void Free()
    {
        this.Guests = null;
    }

    public void RequestRoomService()
    {
        this.Bill.AddService(service);
    }
    
    
}