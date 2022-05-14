using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FortCode.Data
{
    public class Cities
    {
        [Key]
        public int IdCity { get; set; }
        public string Name { get; set; }
        public string Country { get; set; }
    }
}
