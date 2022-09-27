namespace ArticleWebApplicationTest
{
    public class DictionarySource
    {
        public Guid Id { get; set; }
        public string SoursePath { get; set; }

        public virtual List<GoodWord> GoodWords { get; set; }

        public virtual List<BadWord> BadWords { get; set; }
    }
}