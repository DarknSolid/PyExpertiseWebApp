﻿namespace WebApp.Models
{
    public class RepositoriesResultModel
    {
        public string Username { get; set; }
        public IEnumerable<RepositoryResult> Repositories { get; set; }
    }

    public class RepositoryResult
    {
        public string RepositoryName { get; set; }
        public int UserCommits { get; set; }
        public string Url { get; set; }
    }
}
