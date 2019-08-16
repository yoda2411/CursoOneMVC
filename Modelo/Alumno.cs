namespace Modelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using System.Linq;

    [Table("Alumno")]
    public partial class Alumno
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Alumno()
        {
            Adjunto = new HashSet<Adjunto>();
            AlumnoCurso = new HashSet<AlumnoCurso>();
        }

        [Key]
        public int IdAlumno { get; set; }

        [Required]
        [StringLength(50)]
        public string Nombre { get; set; }

        [Required]
        [StringLength(50)]
        public string Apellido { get; set; }

        [Required]
        [StringLength(1)]
        public string Sexo { get; set; }

        public DateTime FechaDeNacimiento { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Adjunto> Adjunto { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AlumnoCurso> AlumnoCurso { get; set; }


        public List<Alumno> GetAll()
        {
            List<Alumno> getRegs = new List<Alumno>();
            try
            {
                using (var ctx = new DBCursoContext())
                {
                    getRegs = ctx.Alumno.ToList();
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            return getRegs;
        }
        public Alumno GetById(int id)
        {
            Alumno alum = new Alumno();
            try
            {
                using (var ctx=new DBCursoContext())
                {
                    alum = ctx.Alumno.Include("AlumnoCurso")
                        .Include("AlumnoCurso.Cuso")
                        .Where(x => x.IdAlumno == id).SingleOrDefault();
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            return alum;
        }
    }
}
