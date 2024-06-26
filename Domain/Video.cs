﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApiBasic.Domain
{
    [Table("Video")]
    public class Video
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string VideoId { get; set; }
        public string NameVideos { get; set; } = null!;
        public string UrlVideo { get; set; } = null!;
        public string AvatarVideoUrl { get; set; } = null!;
        public int Time { get; set; } = 0;
        public DateTime ThoiDiemTao { get; set; }
        public Anime Anime { get; set; } = null;
        public ICollection<Comment> Comments { get; set; }
        public ICollection<UserLikeVideo> userLikeVideos { get; set; }
        public ICollection<UserDisLikeVideo> userDisLikeVideos { get; set; }
        public ICollection<UserXemVideo> userXemVideos { get; set; }
        public ICollection<UserUpVideo> userUpVideos { get; set; }
        public ICollection<UserDownloadVideo> userDownloadVideo { get; set; }
    }
}
