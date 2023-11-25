using System;
using System.Collections.Generic;

namespace MGS_Keyboard_RFID_Scanner
{
    public class RFIDitems : IEquatable<RFIDitems>
    {
        public long RFIDText { get; set; }

        public int Id { get; set; }

        public override string ToString()
        {
            return "ID: " + Id + "   RFID: " + RFIDText;
        }
        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            RFIDitems objAsPart = obj as RFIDitems;
            if (objAsPart == null) return false;
            else return Equals(objAsPart);
        }
        public override int GetHashCode()
        {
            return Id;
        }
        public bool Equals(RFIDitems other)
        {
            if (other == null) return false;
            return (this.Id.Equals(other.Id));
        }

    }
}
