namespace WebApp.Models
{
    public class ImportResult
    {
        public IEnumerable<string> LibrariesToAssess { get; set; }
        public IEnumerable<Library> Imports { get; set; }
    }

    public class Library
    {
        public string Name { get; set; }
        public int TotalImports { get; set; }
        public bool IsStandardLibrary { get; set; }
    }
}
