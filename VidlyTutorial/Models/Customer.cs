using System.ComponentModel.DataAnnotations;
using VidlyTutorial.Models;

namespace VidlyTutorial.Models
{
    public class Customer
    {
        public int id { get; set; }

        [Required]
        [StringLength(255)]
        [DataType(DataType.Password)]
        public string name { get; set; }

        [Required]
        public bool IsSubscribedToNewsletter { get; set; }
        
        public MembershipType MembershipType { get; set; }
        
        public byte MembershipTypeID { get; set; }

        public byte extra1 { get; set; }

        public byte del_flag { get; set; }
    }
}