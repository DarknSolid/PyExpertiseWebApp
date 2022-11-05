namespace WebApp.Models
{
    public class FinalSubmitModel
    {
        public string Email { get; set; }
        public IList<string> Urls { get; set; }
        public IDictionary<string,int> Imports { get; set; }

        public IDictionary<string, int> ImportToRating { get; set; }

        public IDictionary<string, string> ImportToNote { get; set; }
    }
}
