namespace Modelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Adjunto")]
    public partial class Adjunto
    {
        [Key]
        public int IdAdjunto { get; set; }

        public int IdAlumno { get; set; }

        [Required]
        [MaxLength(1)]
        public byte[] Archivo { get; set; }

        public virtual Alumno Alumno { get; set; }
    }
}
