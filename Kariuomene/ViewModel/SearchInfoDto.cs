namespace Kariuomene.ViewModel
{
    public class SearchInfoDto : Info
    {
        public string FullName { get { return string.Format("{0} {1}", Name, Lastname); } }
        public string DepartmentTitle { get; set; }
    }
}