namespace VidlyTutorial.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class edu_Sub_Institute
    {
        [StringLength(50)]
        public string trust_id { get; set; }

        [StringLength(50)]
        public string sub_institute_id { get; set; }

        public string sub_institute_name { get; set; }

        [StringLength(50)]
        public string sub_institute_type { get; set; }

        [StringLength(3000)]
        public string address_line1 { get; set; }

        [StringLength(3000)]
        public string address_line2 { get; set; }

        [StringLength(50)]
        public string city { get; set; }

        [StringLength(50)]
        public string state { get; set; }

        [StringLength(50)]
        public string pincode { get; set; }

        [StringLength(20)]
        public string country { get; set; }

        [StringLength(50)]
        public string contact_no { get; set; }

        [StringLength(150)]
        public string email_id { get; set; }

        [StringLength(200)]
        public string website { get; set; }

        [StringLength(200)]
        public string url { get; set; }

        public string doc_path { get; set; }

        [StringLength(50)]
        public string person_fname { get; set; }

        [StringLength(50)]
        public string person_mname { get; set; }

        [StringLength(50)]
        public string person_lname { get; set; }

        [StringLength(15)]
        public string person_contact { get; set; }

        [StringLength(50)]
        public string person_email { get; set; }

        [StringLength(10)]
        public string total_students { get; set; }

        [StringLength(10)]
        public string total_staff { get; set; }

        [Key]
        [Column(Order = 0)]
        public bool is_approved { get; set; }

        [StringLength(50)]
        public string approved_by { get; set; }

        public DateTime? approval_date { get; set; }

        [Key]
        [Column(Order = 1)]
        public bool is_deleted { get; set; }

        [StringLength(100)]
        public string medium { get; set; }

        public string standard { get; set; }

        public string extra1 { get; set; }

        public string extra2 { get; set; }

        public string extra3 { get; set; }

        public string extra4 { get; set; }

        public string extra5 { get; set; }
    }
}
