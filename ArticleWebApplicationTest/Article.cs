namespace ArticleWebApplicationTest
{
    public class Article
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string ArticleContent { get; set; }
        public DateTime ReleaseArticleDate { get; set; }
        public float Rating { get; set; }
        public int NumberOfViews { get; set; }

        public Guid ArticleSourceId { get; set; }
        public ArticleSource ArticleSource { get; set; }

        public virtual List<Comment> Comments { get; set; }
    }
}
