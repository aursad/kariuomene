namespace Kariuomene.ViewModel
{
    public class SearchInfoDto : Info
    {
        public string FullName { get { return string.Format("{0} {1}", Name, Lastname); } }
        public string DepartmentTitle { get; set; }
    }

    public class Info
    {
        public string Pos { get; set; }
        public string Number { get; set; }
        public string Name { get; set; }
        public string Lastname { get; set; }
        public string Bdate { get; set; }
        public string info { get; set; }
        public string Region { get; set; }
        public string Department { get; set; }
    }

    public class SearchDto
    {
        public bool Found { get; set; }
        public Info Info { get; set; }
    }

    public class SearchViewModel
    {
        public SearchDto Data { get; set; }
        public string Message { get; set; }
        public bool Success { get; set; }
    }
}
