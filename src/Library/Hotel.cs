namespace Library;

public class Hotel
{
    public string Name {get; set;}
    
    private ArrayList rooms = new ArrayList();
    
    private ArrayList roomServices = new ArrayList();

    public Room CheckIn(GuestGroup group, double costPerNight)
    {
        if (group == null)
        {
            return null; // No hay un grupo para hacer el check in
        }

        foreach (Room room in this.rooms)
        {
            bool roomIsFree = room.Guests == null;
            bool roomHasCapacity = room.MaxGuests >= group.NumberOfGuests;
            if (roomIsFree && roomHasCapacity)
            {
                room.Occupy(group);
                room.Bill.Nights = group.NightsToStay;
                room.Bill.RoomCostPerNight = costPerNight; 
                return room;
            }
        }
        return null;
    }
    
    public void CheckOut(GuestGroup group)
    {
        foreach (Room room in this.rooms)
        {
            bool groupIsOnThisRoom = room.Guests == group;
            if (groupIsOnThisRoom)
            {
                room.Free();
                break;
            }
        }
    }
    
    public void BuildRoom(Room room)
    {
        this.rooms.Add(room);
    }
    
    public void AddRoomService(RoomService roomService)
    {
        this.roomServices.Add(roomService);
    }
}

