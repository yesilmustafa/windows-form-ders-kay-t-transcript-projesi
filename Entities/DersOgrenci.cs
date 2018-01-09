using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace A8CFManyToMany.Entities
{
    [Table("DersOgrencileri")]
    public class DersOgrenci
    {
        [Key]
        [Column(Order = 1)]
        public int DersID { get; set; }
        [Key]
        [Column(Order = 2)]
        public int OgrenciID { get; set; }
        public DateTime KayitTarihi { get; set; } = DateTime.Now;

        [ForeignKey("DersID")]
        public virtual Ders Ders { get; set; }
        [ForeignKey("OgrenciID")]
        public virtual Ogrenci Ogrenci { get; set; }
    }
}
