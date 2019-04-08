namespace Team1.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("UserInRole")]
    public partial class UserInRole
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int UserInRoleId { get; set; }

        public int UserId { get; set; }

        public int RoleId { get; set; }

        public DateTime HireDate { get; set; }
    }
}
