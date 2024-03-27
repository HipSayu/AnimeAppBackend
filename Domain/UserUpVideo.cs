using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ApiBasic.Domain
{
    [Table("UserUpVideo")]
    public class UserUpVideo
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int UserId { get; set; }

        public int VideoId { get; set; }

        public User User { get; set; }

        public Video Video { get; set; }
    }
}
