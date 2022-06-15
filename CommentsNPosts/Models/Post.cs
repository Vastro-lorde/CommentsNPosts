using System.ComponentModel.DataAnnotations;

namespace CommentsNPosts.Models
{
    public class Post
    {
        public Guid PostId { get; set; }
        [Required]
        public string Title { get; set; }
        public string Description { get; set; }
        [Required]
        public string PostBody { get; set; }
        public DateTime Created { get; set; }
        public bool Deleted { get; set; }
        public int Likes { get; set; }
        public Guid UserId { get; set; }
        public User User { get; set; }
        public ICollection<Comment> Comments { get; set; }
    }
}
