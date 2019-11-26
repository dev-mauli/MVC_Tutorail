using VidlyTutorial.Models;

namespace VidlyTutorial.ViewModels
{
    public class Customer
    {

        public int id { get; set; }

        public string name { get; set; }

        public bool IsSubscribedToNewsletter { get; set; }

        public MembershipType MembershipType { get; set; }

        public byte MembershipTypeID { get; set; }
    }
}