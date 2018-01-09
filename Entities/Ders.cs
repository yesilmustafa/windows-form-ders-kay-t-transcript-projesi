using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace A8CFManyToMany.Entities
{
    [Table("Dersler")]
    public class Ders
    {
        [Key]
        public int DersID { get; set; }
        [Required]
        [StringLength(50)]
        public string DersAdi { get; set; }
        public byte Kredi { get; set; } = 0;

        public virtual List<DersOgrenci> Ogrenciler { get; set; } = new List<DersOgrenci>();
        public override string ToString()
        {
            return $"{DersAdi} - {Kredi}";
        }
    }
}
