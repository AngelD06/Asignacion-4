namespace model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using System.Linq;

    [Table("InformacionGeneral")]
    public partial class InformacionGeneral
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int info_id { get; set; }

        [StringLength(40)]
        public string Nombre { get; set; }

        [StringLength(40)]
        public string apellido { get; set; }

        [Column(TypeName = "date")]
        public DateTime? fecha_de_nacimiento { get; set; }

        [StringLength(1)]
        public string genero { get; set; }

        public InformacionGeneral MostrarMiinformacion(int id)
        {
            var persona = new InformacionGeneral();

            using (var context = new CurriculumContext())
            {
                persona = context.InformacionGeneral.Where(x => x.info_id == id)
                                                    .SingleOrDefault();
            }
            return persona;
        }
    }
}
