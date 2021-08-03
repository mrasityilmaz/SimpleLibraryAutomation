namespace WindowsFormsApp1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Deposits
    {
        public int ID { get; set; }

        [StringLength(50)]
        public string Kitap_adi { get; set; }

        [StringLength(50)]
        public string Yazar_adi { get; set; }

        public int? Baski_yili { get; set; }

        public int? Sayfa_sayisi { get; set; }

        [StringLength(50)]
        public string Dili { get; set; }

        [StringLength(50)]
        public string Yayin_evi { get; set; }

        [StringLength(50)]
        public string Emanet_alan_üye { get; set; }

        [Column(TypeName = "date")]
        public DateTime? Alis_tarihi { get; set; }

        [Column(TypeName = "date")]
        public DateTime? Teslim_tarihi { get; set; }

        public bool? Teslim_durumu { get; set; }

        [StringLength(250)]
        public string Emanet_notu { get; set; }
    }
}
