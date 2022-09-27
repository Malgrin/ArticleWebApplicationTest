namespace ArticleWebApplicationTest
{
    public class User
    {
        public Guid Id { get; set; }
        public string NickName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public float DesiredArticleRating { get; set; }

        public virtual List<Comment> Comments { get; set; }

        public Guid UserRoleId { get; set; }
        public virtual UserRole UserRole { get; set; }

        public Guid UserStatusId { get; set; }
        public virtual UserStatus UserStatus { get; set; }
    }
}