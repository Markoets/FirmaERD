using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace TARge20.Core.Domain
{
    public class Laenutamine
    {
        [Key]
        public Guid Id { get; set; }

        [ForeignKey(nameof(TöötajaID))]
        public Guid TöötajaID { get; set; }

        public string Asi { get; set; }

        public DateTime Leanutuse_alguskuupäev { get; set; }

        public DateTime Leanutuse_lõppkuupäev { get; set; }

    }
}
