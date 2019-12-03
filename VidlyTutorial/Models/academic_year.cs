namespace VidlyTutorial.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class academic_year
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(50)]
        public string AYID { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string Duration { get; set; }

        [StringLength(100)]
        public string Remark { get; set; }

        [Key]
        [Column(Order = 2)]
        public bool IsCurrent { get; set; }
    }
}
