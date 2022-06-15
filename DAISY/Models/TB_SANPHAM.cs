namespace DAISY.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tb_SANPHAM
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tb_SANPHAM()
        {
            tb_CUAHANG_SPCT = new HashSet<tb_CUAHANG_SPCT>();
            tb_SANPHAM_SPDK = new HashSet<tb_SANPHAM_SPDK>();
            tb_KICHCO = new HashSet<tb_KICHCO>();
        }

        [Key]
        public int IDSANPHAM { get; set; }

        public int IDLOAISANPHAM { get; set; }

        [Required]
        [StringLength(100)]
        public string TENSANPHAM { get; set; }

        [StringLength(100)]
        public string HINHANH { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_CUAHANG_SPCT> tb_CUAHANG_SPCT { get; set; }

        public virtual tb_LOAISANPHAM tb_LOAISANPHAM { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_SANPHAM_SPDK> tb_SANPHAM_SPDK { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_KICHCO> tb_KICHCO { get; set; }
    }
}
