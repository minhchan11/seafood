using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Seafood.Models
{
    [Table("Infos")]
    public class Info
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        public string MainImage { get; set; }
        public string About { get; set; }
    }
}
