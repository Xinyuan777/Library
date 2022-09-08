namespace onlinestore.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ActionLog_Tb
    {
        [Key]
        [Column(Order = 0), DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int No_F { get; set; }

        [Required]
        [StringLength(10)]
        public string UserID_F { get; set; }

        [Required]
        [StringLength(255)]
        public string Action_F { get; set; }

        public string Description_F { get; set; }

        [Required]
        [StringLength(50)]
        public string RemoteIP_F { get; set; }

        public DateTime JoinTime_F { get; set; }

        public virtual MemberData_Tb MemberData_Tb { get; set; }
    }
}
