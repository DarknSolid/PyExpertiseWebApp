namespace WebApp.Models
{
    public class ImportResult
    {
        public IEnumerable<string> LibrariesToAssess { get; set; }
        public IDictionary<string,int> Imports { get; set; }
    }
}
