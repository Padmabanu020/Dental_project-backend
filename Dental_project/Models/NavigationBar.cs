namespace Dental_project.Models
{
    public class NavigationBar
    {
        public int Id { get; set; }
        public string MenuName{ get; set; }
        public bool IsFooter { get; set; }
        public bool IsHeader { get; set; }
        public int? ParentId { get; set; }

    }
}
