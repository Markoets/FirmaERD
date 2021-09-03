using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace TARge20.Core.Domain
{
    public class Laps
    {
        [Key]
        public Guid Id { get; set; }
        public string EesNimi { get; set; }
        public DateTime Sünnipäev { get; set; }
        public int Vanus { get; set; }

    }
}
