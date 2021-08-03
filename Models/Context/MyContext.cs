using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    // Burada veritabaný baðlantýmýzý tanýmladýk ve proje klasörümüzün bin/debug klasörü içinde bulunan veritabaný dosyamýzý localdb aracýlýðýyla attach ettik.
    // Projeyi Setupa çekerken veritabaný dosyasýný setupa eklemeyi unutmayalým.
    // Programý kullanmak için bilgisayarýnýzda mssql veya localdb yüklü olmasý gerektiðini unutmayýn!
    public partial class MyContext : DbContext
    {
        public static readonly string ConnectionString = ("Server=.;Database=MyLibraryDatabase;Trusted_Connection=True;");

        public MyContext()
            : base(ConnectionString)//App.config->connectionstring->name   or ConnectionString
        {
            Configuration.LazyLoadingEnabled = false;
            
        }

        public virtual DbSet<Books> Books { get; set; }
        public virtual DbSet<Deposits> Deposits { get; set; }
        public virtual DbSet<Members> Members { get; set; }
        public virtual DbSet<Users> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            
        }
    }
}
