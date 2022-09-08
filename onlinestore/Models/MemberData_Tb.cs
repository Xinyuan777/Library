namespace onlinestore.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class MemberData_Tb
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public MemberData_Tb()
        {
            
            MessageData_Tb = new HashSet<MessageData_Tb>();
        }
        public int No_F { get; set; }

        [Key]
        [StringLength(10)]
        public string UserID_F { get; set; }

        [StringLength(50)]
        public string Password_F { get; set; }

        [StringLength(50)]
        public string UserName_F { get; set; }

        [StringLength(50)]
        public string NickName_F { get; set; }

        [StringLength(255)]
        public string Email_F { get; set; }

        public bool IsAdmin_F { get; set; }

        public int? Emotionlcon_F { get; set; }

        [StringLength(36)]
        public string AuthCode_F { get; set; }

        public DateTime? JoinTime_F { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MessageData_Tb> MessageData_Tb { get; set; }
    }
}
