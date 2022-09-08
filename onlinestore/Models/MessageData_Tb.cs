namespace onlinestore.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class MessageData_Tb
    {
        [Key]
        [Column(Order = 0), DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int No_F { get; set; }

        [Required]
        [StringLength(10)]
        public string UserID_From_F { get; set; }
        public string Email_F { get; set; }

        public string Content_F { get; set; }

        public bool IsSecret_F { get; set; }

        public string AdminReply_F { get; set; }

        public DateTime? AdminReplyTime_F { get; set; }

        public DateTime? JoinTime_F { get; set; }

        public virtual MemberData_Tb MemberData_Tb { get; set; }
    }
}
