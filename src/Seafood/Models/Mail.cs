using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Seafood.Models
{
    [Table("Mails")]
    public class Mail
    {
        [Key]
        public int Id { get; set; }
        public string Email { get; set; }
        public string Preference { get; set; }
    }
}
