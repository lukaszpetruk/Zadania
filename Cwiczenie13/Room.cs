using System;
using System.Collections.Generic;
using System.Text;

namespace Cwiczenie13
{
    interface IHasExteriorDoor
    {
        string DoorDescription { get; }
        Location DoorLocation { get; set; }
    }
    class Room  : Location
    {
        private string decoration;
        public Room(string name, string decoration)
            : base(name)
        {
            this.decoration = decoration;
        }
        public override string Description
        {
            get
            {
                return base.Description + "Widzisz tutaj " + decoration + ".";
            }
        }
    }
    class RoomWithDoor : Room, IHasExteriorDoor
    {
        public RoomWithDoor(string name, string decoration, string doorDescription)
            : base(name, decoration)
        {
            DoorDescription = doorDescription;
        }
        public string DoorDescription { get; private set; }
        public Location DoorLocation { get; set; }
    }
}
