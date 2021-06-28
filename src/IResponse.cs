namespace Mh.Aladin
{
    public interface IResponse
    {
        string Version { get; }
        string Logo { get; }
        string Title { get; }
        string Link { get; }
        string PubDate { get; }
        int TotalResults { get; }
        int StartIndex { get; }
        int ItemsPerPage { get; }
        string Query { get; }
        int SearchCategoryId { get; }
        string SearchCategoryName { get; }
        int ErrorCode { get; }
        string ErrorMessage { get; }
    }
}
