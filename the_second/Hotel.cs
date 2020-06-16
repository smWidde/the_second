using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace the_second
{
    public class Hotel
    {
        public List<HotelRoom> Rooms {get; set;}
        public string Title { get; private set; }
        private static Hotel instance;
        private Hotel()
        {
            Rooms = new List<HotelRoom>();
            instance = this;
        }
        public static Hotel GetHotel()
        {
            if (instance == null)
                return new Hotel();
            return instance;
        }
        public void RemoveRoom(string room_number)
        {
            for(int i=0; i<Rooms.Count; i++)
            {
                if(Rooms[i].Number==room_number)
                {
                    Rooms.RemoveAt(i);
                    break;
                }
            }
        }
        public void AddRoom(HotelRoom room)
        {
            Rooms.Add(room);
        }
        public void AddRoom(string Number, bool IsAvailable, int Cost)
        {
            Rooms.Add(new HotelRoom() { Number= Number, IsAvailable=IsAvailable, Cost=Cost });
        }
        public void SetRoomAvailability(string room_number, bool IsAvailable)
        {
            for (int i = 0; i < Rooms.Count; i++)
            {
                if (Rooms[i].Number == room_number)
                {
                    Rooms[i].IsAvailable = IsAvailable;
                    break;
                }
            }
        }
    }
}