using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace api.Models
{
    public class Purchase
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int Userid { get; set; }
        public string Img { get; set; }
        public string Itemname { get; set; }
        public string Itemprice { get; set; }
        public string Status { get; set; }
    }
}
