namespace TheWaterProject.Models.ViewModels
{
    public class ProjectsListViewModel
    {
        public IQueryable<Project> Projects { get; set;}
        public PaginationInfo PaginationInfo { get; set; } = new PaginationInfo();
        // public IEnumerable<Project> Projects { get; set; } 
        //     = Enumerable.Empty<Project>();
        // public PaginationInfo PaginationInfo { get; set; } = new();
        public string? CurrentProjectType { get; set; }

    }
}
