using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace A8CFManyToMany.Entities
{
    [Table("Ogrenciler")]
    public class Ogrenci
    {
        [Key]
        public int OgrenciID { get; set; }
        [Required]
        [StringLength(20)]
        public string Ad { get; set; }
        [Required]
        [StringLength(30)]
        public string Soyad { get; set; }
        [Column(TypeName = "date")]
        public DateTime DogumTarihi { get; set; }
        [NotMapped]
        public int Yas
        {
            get
            {
                return DateTime.Now.Year - this.DogumTarihi.Year;
            }
        }
        public Cinsiyetler Cinsiyet { get; set; } = Cinsiyetler.Belirsiz;
        public virtual List<DersOgrenci> Dersler { get; set; } = new List<DersOgrenci>();
        public override string ToString()
        {
            return $"{Ad} {Soyad} - {Yas} {Cinsiyet.ToString().Substring(0, 1)}";
        }
    }
    public enum Cinsiyetler : byte { Erkek, Kadın, Belirsiz }
}
