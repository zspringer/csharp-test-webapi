namespace csharp_test_webapi
{
    public class Magazine : IPublication
    {
        public string Title { get; set ; }
        public string Publisher { get ; set ; }
        public int Pages { get ; set ; }
        public string Headline;
        public int Issue;

        public Magazine(string title, string publisher, int pages, string headline, int issue)
        {
            Title = title;
            Publisher = publisher;
            Pages = pages;
            Headline = headline;
            Issue = issue;
        }
    }
}