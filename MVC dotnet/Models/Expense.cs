using System.ComponentModel.DataAnnotations;

namespace MVC_dotnet.Models
{
    public class Expense
    {
        public int id { get; set; }
        public decimal Value { get; set; }
        [Required] public string? Description { get; set; }
    }
}
