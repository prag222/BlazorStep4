using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace BlazorStep4.Shared
{
    public class Customer
    {
        public int Id { get; set; }
        public string? Name { get; set; } = default!;
        [Required(ErrorMessage ="Please Enter Street")]
        public string? Street { get; set; } = default!;
        public string? City { get; set; }
    }
}
