using Microsoft.EntityFrameworkCore;

namespace ArticleWebApplicationTest
{
    public class ArticleDbContext: DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Article> Articles { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<UserRole> UserRoles { get; set; }
        public DbSet<UserStatus> UserStatuses { get; set; }
        public DbSet<ArticleSource> ArticleSources { get; set; }
        public DbSet<DictionarySource> DictionarySources { get; set; }
        public DbSet<GoodWord> GoodWords { get; set; }
        public DbSet<BadWord> BadWords { get; set; }

        private const string ConnectionString =
            "Server=DESKTOP-TSIG4LI\\SQLEXPRESS;" +
            "Database=ArticleSampleDB;" +
            "Trusted_Connection=True;";

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(ConnectionString);
        }

    }
}
