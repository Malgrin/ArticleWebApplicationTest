namespace ArticleWebApplicationTest
{
    public class UserRole
    {
        public Guid Id { get; set; }
        public string Role { get; set; }

        public virtual List<User> Users { get; set; }
    }
}