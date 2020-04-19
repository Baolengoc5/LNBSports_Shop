namespace Models.Frameworks
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Admin")]
    public partial class Admin
    {
        [Key]
        [Column("Admin")]
        [StringLength(50)]
        public string Admin1 { get; set; }

        [StringLength(32)]
        public string PasswordAd { get; set; }
    }
}
