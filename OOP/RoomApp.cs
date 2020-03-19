using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
    class RoomApp
    {
        public void Run()
        {
            Console.WriteLine("Hey welcome to the GC Room measurer");
            Room room = AskForRoom();
            LogRoomDimensions(room);
        }

        private Room AskForRoom()
        {
            Console.WriteLine("give me the length, width and height of this room!");

            double length = double.Parse(Console.ReadLine());
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());

            Room room = new Room(length, width, height);

            return room;
        }

        private void LogRoomDimensions(Room room)
        {
            Console.WriteLine($"Area: {room.GetArea()}");
            Console.WriteLine($"Volume: {room.GetVolume()}");
        }
    }
}
