namespace WebApp.Models
{
    public class ImportResult
    {
        public IEnumerable<string> LibrariesToAssess { get; set; }
        public IEnumerable<Import> Imports { get; set; }
    }

    public class Import
    {
        public string Library { get; set; }
        public int Count { get; set; }
    }
}
