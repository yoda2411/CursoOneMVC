namespace Modelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("AlumnoCurso")]
    public partial class AlumnoCurso
    {
        [Key]
        public int IdAlumnoCurso { get; set; }

        public int IdAlumno { get; set; }

        public int IdCurso { get; set; }

        public int? NOTA { get; set; }

        public virtual Alumno Alumno { get; set; }

        public virtual Cuso Cuso { get; set; }
    }
}
