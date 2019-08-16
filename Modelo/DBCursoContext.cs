namespace Modelo
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class DBCursoContext : DbContext
    {
        public DBCursoContext()
            : base("name=DBCursoContext")
        {
        }

        public virtual DbSet<Adjunto> Adjunto { get; set; }
        public virtual DbSet<Alumno> Alumno { get; set; }
        public virtual DbSet<AlumnoCurso> AlumnoCurso { get; set; }
        public virtual DbSet<Cuso> Cuso { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Alumno>()
                .Property(e => e.Sexo)
                .IsUnicode(false);

            modelBuilder.Entity<Alumno>()
                .HasMany(e => e.Adjunto)
                .WithRequired(e => e.Alumno)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Alumno>()
                .HasMany(e => e.AlumnoCurso)
                .WithRequired(e => e.Alumno)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Cuso>()
                .HasMany(e => e.AlumnoCurso)
                .WithRequired(e => e.Cuso)
                .WillCascadeOnDelete(false);
        }
    }
}
