namespace ArticleWebApplicationTest
{
    public class Comment
    {
        public Guid Id { get; set; }
        public string CommentContent { get; set; }
        public DateTime ReleaseCommentDate { get; set; }

        public Guid ArticleId { get; set; }
        public virtual Article Article { get; set; }

        public Guid UserId { get; set; }
        public virtual User User { get; set; }
    }
}