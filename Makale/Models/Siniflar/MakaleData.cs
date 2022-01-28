using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Makale.Models.Siniflar
{
    public class MakaleData
    {
        [Key]
        public int MakaleID { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(30)]
        public string MakaleTür { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(30)]
        public string MakaleAd { get; set; }
        [Column(TypeName = "Varchar")]
        public string MakaleText { get; set; }

    }
}