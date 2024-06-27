namespace Application.DTO.Pagination
{
    public class Parameters
    {
        public int PageNumber { get; set; }
        public int PageSize { get; set; }

        public Parameters(int pageNumber, int pageSize)
        {
            PageNumber = pageNumber;
            PageSize = pageSize;
        }

        public Parameters() { }
    }
}
