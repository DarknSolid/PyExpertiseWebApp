namespace WebApp.Models
{
    public class SurveyModel
    {
        public IDictionary<string, int> ImportToRating { get; set; }

        public IDictionary<string, string> ImportToNote { get; set; }

        public SurveyModel()
        {
            ImportToRating = new Dictionary<string, int>();
            ImportToNote = new Dictionary<string, string>();
        }
    }
}
