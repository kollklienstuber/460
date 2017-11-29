namespace hw8.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Artist
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Artist()
        {
            ArtWorks = new HashSet<ArtWork>();
        }

        public int ArtistID { get; set; }

        [Required]
        [Display(Name = "Artist Name")]
        [StringLength(128)]
        public string ArtistName { get; set; }

        [Required]
        [Display(Name = "Artist Birth City")]
        [StringLength(128)]
        public string ArtistCity { get; set; }

        [Display(Name = "Artist Birth Day")]
        [Column(TypeName = "date")]
        public DateTime ArtistDOB { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ArtWork> ArtWorks { get; set; }
    }
}
