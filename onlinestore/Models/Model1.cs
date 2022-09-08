using System.Data.Entity;

namespace onlinestore.Models
{
    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        public virtual DbSet<MemberData_Tb> MemberData_Tb { get; set; }
        public virtual DbSet<MessageData_Tb> MessageData_Tb { get; set; }
        public virtual DbSet<sysdiagrams> Sysdiagrams { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {


            modelBuilder.Entity<MemberData_Tb>()
                .Property(e => e.AuthCode_F)
                .IsUnicode(false);



            modelBuilder.Entity<MemberData_Tb>()
                .HasMany(e => e.MessageData_Tb)
                .WithRequired(e => e.MemberData_Tb)
                .HasForeignKey(e => e.UserID_From_F)
                .WillCascadeOnDelete(true);
        }
    }
}
