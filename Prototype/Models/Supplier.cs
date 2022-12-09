using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Prototype.Models
{
    public class Supplier
    {
        public int ID { get; set; }

        [Required(ErrorMessage = "Company Name Required")]
        public string Name { get; set; } = string.Empty;

        [Required(ErrorMessage = "Telephone Number Required")]
        [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$", ErrorMessage = "Entered phone format is not valid.")]
        public string Telephone { get; set; } = string.Empty;
    }
}
