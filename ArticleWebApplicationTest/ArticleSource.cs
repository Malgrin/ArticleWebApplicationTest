namespace ArticleWebApplicationTest
{
    public class ArticleSource
    {
        public Guid Id { get; set; }
        public string ArticleSourcePath { get; set; }

        public virtual List<Article> Articles { get; set; }
    }
}
