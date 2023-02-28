using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace training_dotnet6_api.Models
{
    public class Contato
    {
        [Required]
        public int Id { get; set; }
        [AllowNull]
        public string Name { get; set; }
        [AllowNull]
        public string Email { get; set; }
        [AllowNull]
        public string Number { get; set; }
    }
}
