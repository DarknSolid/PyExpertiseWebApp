namespace WebApp.Models
{
    public class AnalysisProgressModel
    {
        public int Count { get; set; }
        public int Total { get; set; }
        public bool IsInProgress { get; set; }
        public string CurrentRepositoryName { get; set; }
    }
}
