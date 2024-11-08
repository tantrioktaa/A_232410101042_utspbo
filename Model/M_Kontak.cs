using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_232410101042_utspbo.Model
{
    internal class M_Kontak
    {
        [Key]
        public int id { get; set; }
        [Required]
        public string nama { get; set; }
        [Required]
        public string no_hp { get; set; }
        [Required]
        public string email { get; set; }
    }
}
