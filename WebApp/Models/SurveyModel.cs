namespace WebApp.Models
{
    public class SurveyModel
    {
        public IDictionary<string, int> Answers { get; set; }

        public SurveyModel() 
        {
            Answers = new Dictionary<string, int>();
        }
    }
}
