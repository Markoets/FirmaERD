using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace TARge20.Core.Domain
{
    public class Töötaja
    {
        [Key]
        public Guid Id { get; set; }
        public string EesNimi { get; set; }
        public string PerekonnaNimi { get; set; }
        public Guid Ametinimetus_ID { get; set; }
        [ForeignKey(nameof(Puhkus_Id))]
        public Guid Puhkus_Id { get; set; }
        [ForeignKey(nameof(Lapsed_ID))]
        public Guid Lapsed_ID { get; set; }
        [ForeignKey(nameof(Haigusleht_ID))]
        public Guid Haigusleht_ID { get; set; }
        [ForeignKey(nameof(Laenutused_ID))]
        public Guid Laenutused_ID { get; set; }
    }
}
