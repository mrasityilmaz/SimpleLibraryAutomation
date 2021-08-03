namespace WindowsFormsApp1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Books
    {
        public int ID { get; set; }

        [StringLength(50)]
        public string Kitap_adi { get; set; }

        [StringLength(50)]
        public string Yazar_adi { get; set; }

        [StringLength(50)]
        public string Baski_yili { get; set; }

        [StringLength(50)]
        public string Sayfa_sayisi { get; set; }

        [StringLength(50)]
        public string Dili { get; set; }

        [StringLength(50)]
        public string Yayin_evi { get; set; }

        [StringLength(250)]
        public string Hakkinda { get; set; }
    }
}
