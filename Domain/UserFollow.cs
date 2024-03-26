namespace ApiBasic.Domain
{
    public class UserFollow
    {
        public int FollowerId { get; set; } // UserId của người theo dõi
        public User Follower { get; set; }

        public int FollowingId { get; set; } // UserId của người được theo dõi
        public User Following { get; set; }
    }
}
