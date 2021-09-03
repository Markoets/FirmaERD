using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace TARge20.Core.Domain
{
    public class Puhkus
    {
        [Key]
        public Guid Id { get; set; }
        [ForeignKey(nameof(TöötajaID))]
        public Guid TöötajaID { get; set; }

        public DateTime  Alguskuupäev { get; set; }

        public DateTime Lõppkuupäev { get; set; }
    }
}
