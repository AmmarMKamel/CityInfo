namespace CityInfo.API.Services
{
    public class PaginationMetadata
    {
        public int TotalItemCount { get; set; }
        public int TotalPageCount { get; set; }
        public int PageSize { get; set; }
        public int CurrentPage { get; set; }

        public PaginationMetadata(int totalItemCount, int pageNumber, int pageSize)
        {
            TotalItemCount = totalItemCount;
            PageSize = pageSize;
            CurrentPage = pageNumber;
            TotalPageCount = (int)Math.Ceiling(totalItemCount / (double)pageSize);
        }
    }
}
