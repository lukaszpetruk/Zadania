using System;
using System.Collections.Generic;
using System.Text;

namespace Cwiczenie13
{
    class Outside : Location 
    {
        private bool hot;
        public Outside(string name, bool hot)
            : base(name)
        {
            this.hot = hot;
        }
        public override string Description
        {
            get
            {
                string NewDescription = base.Description;
                if (hot)
                    NewDescription += " Tutaj jest bardzo gorąco.";
                return NewDescription;
            }
        }
    }
    class OutsideWithDoor : Outside, IHasExteriorDoor
    {
        public OutsideWithDoor(string name, bool hot, string doorDescription)
            : base(name, hot)
        {
            this.DoorDescription = doorDescription;
        }
        public string DoorDescription { get; private set; }
        public Location DoorLocation { get; set; }
        public override string Description
        {
            get
            {
                return base.Description + " Widzisz teraz " + DoorDescription + ".";
            }
        }
    }
}
