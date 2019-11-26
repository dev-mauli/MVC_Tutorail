using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VidlyTutorial.Models
{
    public class MembershipType
    {
        public byte id { get; set; }

        public short Signupfee { get; set; }

        public byte Durationinmonths { get; set; }

        public byte Discountrate { get; set; }
    }
}