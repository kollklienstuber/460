namespace hw8.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Classification
    {
        [Key]
        public int ClassificationID { get; set; }

        [Required]
        [StringLength(64)]
        public string ArtWork { get; set; }

        [Required]
        [StringLength(64)]
        public string Genre { get; set; }

        public int? GenreID { get; set; }

        public int? ArtWorkID { get; set; }

        public virtual ArtWork ArtWork1 { get; set; }

        public virtual Genre Genre1 { get; set; }
    }
}
