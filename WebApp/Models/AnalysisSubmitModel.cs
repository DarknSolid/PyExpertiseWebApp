namespace WebApp.Models
{
    public class AnalysisSubmitModel
    {
        public string Username { get; set; }
        public IEnumerable<RepositoryResult> Repositories { get; set; }
        public bool IsItu { get; set; }
    }
}
