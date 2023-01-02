using System.Data.Entity;

namespace WebProgramlamaProje.Models.Classes
{
    public class Context:DbContext
    {
        public DbSet<Admin> Admins { get; set; }
        public DbSet<Anasayfa>Anasayfalar{ get; set; }
        
        public DbSet<Kullanici> Kullanicilar { get; set;}
    }
}