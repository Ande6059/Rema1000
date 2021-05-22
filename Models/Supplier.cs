using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Rema1000.Models
{
    public class Supplier
    {
        [Key]
        public int ID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public int ZipCode { get; set; }
        public string Contact { get; set; }
        public string Email { get; set; }
        public int PhoneNumber { get; set; }

    }
}
