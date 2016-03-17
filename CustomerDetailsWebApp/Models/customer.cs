namespace CustomerDetailsWebApp.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("customer")]
    public partial class customer
    {
        [Key]
        public int Custid { get; set; }

        [Required]
        [StringLength(20)]
        public string CustName { get; set; }

        [Required]
        [StringLength(20)]
        public string City { get; set; }

        [StringLength(30)]
        public string Phone { get; set; }

        [StringLength(30)]
        public string Email { get; set; }
    }
}
