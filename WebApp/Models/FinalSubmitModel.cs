namespace WebApp.Models
{
    public class FinalSubmitModel
    {
        public IDictionary<string,int> Answers { get; set; }
        public string Email { get; set; }
        public IList<string> Urls { get; set; }
        public IDictionary<string,int> Imports { get; set; }
    }
}
