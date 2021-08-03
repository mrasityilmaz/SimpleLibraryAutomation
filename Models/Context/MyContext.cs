using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    // Burada veritaban� ba�lant�m�z� tan�mlad�k ve proje klas�r�m�z�n bin/debug klas�r� i�inde bulunan veritaban� dosyam�z� localdb arac�l���yla attach ettik.
    // Projeyi Setupa �ekerken veritaban� dosyas�n� setupa eklemeyi unutmayal�m.
    // Program� kullanmak i�in bilgisayar�n�zda mssql veya localdb y�kl� olmas� gerekti�ini unutmay�n!
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
