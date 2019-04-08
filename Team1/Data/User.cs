namespace Team1.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("User")]
    public partial class User
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int UserId { get; set; }

        [Required]
        [StringLength(256)]
        public string Email { get; set; }

        [Required]
        [StringLength(256)]
        public string UserName { get; set; }

        public DateTime DateBirthday { get; set; }

        [Column("JobTitleId")]
        public int JobTitleId { get; set; }
    }
}
