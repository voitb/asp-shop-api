using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace api.Models
{
    public class User
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Login {get; set; }
        public string Address { get; set; }
        public string Password { get; set; }
        public bool Admin { get; set; }
    }
}
