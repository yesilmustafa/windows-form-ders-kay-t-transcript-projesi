using A8CFManyToMany.Entities;
using System.Data.Entity;

namespace A8CFManyToMany.DAL
{
    public class MyContext : DbContext
    {
        public MyContext()
            : base("name=MyCon")
        { }

        public virtual DbSet<Ders> Dersler { get; set; }
        public virtual DbSet<Ogrenci> Ogrenciler { get; set; }
        public virtual DbSet<DersOgrenci> DersOgrenciler { get; set; }
    }
}
