namespace Mh.Aladin
{
    public abstract class ItemResponse : IResponse
    {
        public string Version { get; set; }
        public string Logo { get; set; }
        public string Title { get; set; }
        public string Link { get; set; }
        public string PubDate { get; set; }
        public int TotalResults { get; set; }
        public int StartIndex { get; set; }
        public int ItemsPerPage { get; set; }
        public string Query { get; set; }
        public int SearchCategoryId { get; set; }
        public string SearchCategoryName { get; set; }
        public int ErrorCode { get; set; }
        public string ErrorMessage { get; set; }
    }
}
