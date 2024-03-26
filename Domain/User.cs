using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ApiBasic.Domain
{
    [Table("User")]
    public class User
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string UserName { get; set; } = null!;

        [MaxLength(50)]
        [MinLength(8)]
        public string Password { get; set; } = null!;

        [RegularExpression("/(84|0[3|5|7|8|9])+([0-9]{8})\b/g")]
        public string SĐT { get; set; }
        public string TieuSu { get; set; }
        public string AvatarUrl { get; set; }
        public string BackgroundUrl { get; set; }

        // Danh sách các user mà user này đang theo dõi
        public ICollection<UserFollow> Following { get; set; }

        // Danh sách các user đang theo dõi user này
        public ICollection<UserFollow> Followers { get; set; }
    }
}
