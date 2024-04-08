using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace mn.Models
{
    public class Danhsach
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(30)]
        [DisplayName("Tên trường")]
        public required string University { get; set; }

    }
}
