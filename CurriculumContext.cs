namespace model
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class CurriculumContext : DbContext
    {
        public CurriculumContext()
            : base("name=CurriculumContext")
        {
        }

        public virtual DbSet<InformacionGeneral> InformacionGeneral { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<InformacionGeneral>()
                .Property(e => e.Nombre)
                .IsUnicode(false);

            modelBuilder.Entity<InformacionGeneral>()
                .Property(e => e.apellido)
                .IsUnicode(false);

            modelBuilder.Entity<InformacionGeneral>()
                .Property(e => e.genero)
                .IsUnicode(false);
        }
    }
}
