using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Albina.DataAccess.Core.Models
{
    [Table("User")]
    class UserRto
    {
      [Key]  public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        [Required] public string PhoneNumberPrefix { get; set; }
        [Required] public string PhoneNumber { get; set; }
        [Required,MinLength(7)] public string Password { get; set; }
        public string ImageName { get; set; }
    }
}
