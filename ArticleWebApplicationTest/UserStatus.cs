namespace ArticleWebApplicationTest
{
    public class UserStatus
    {
        public Guid Id { get; set; }
        public string Status { get; set; }

        public virtual List<User> User { get; set; }
    }
}