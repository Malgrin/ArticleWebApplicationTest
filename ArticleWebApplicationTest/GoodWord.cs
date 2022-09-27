namespace ArticleWebApplicationTest
{
    public class GoodWord
    {
        public Guid Id { get; set; }
        public string Word { get; set; }
        public float WordRating { get; set; }
                
        public Guid DictionarySourceId { get; set; }
        public virtual DictionarySource DictionarySources { get; set; }
    }
}
