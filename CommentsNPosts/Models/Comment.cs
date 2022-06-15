using System.ComponentModel.DataAnnotations;

namespace CommentsNPosts.Models
{
    public class Comment
    {
        public Guid CommentId { get; set; }
        public string Name { get; set; }
        [Required]
        public string Text { get; set; }
        public DateTime Created { get; set; }
        public bool Deleted { get; set; }
        public int Likes { get; set; }
        public Guid PostId { get; set; }
        public Post Post { get; set; }
    }
}
