using Microsoft.EntityFrameworkCore;

namespace Application.DTO.Pagination
{
    public class Paged<T>
    {
        public MetaData MetaData { get; set; }
        public List<T> Data { get; set; }
        
        public Paged(List<T> items, int count, int pageNumber, int pageSize) 
        {
            MetaData = new MetaData()
            {
                TotalCount = count,
                PageSize = pageSize,
                TotalPages = (int)Math.Ceiling(count / (double)pageSize)
            };
            Data = (items);
        }

        public static async Task<Paged<T>> ToPagedAsync(IQueryable<T> entity, int pageNumber, int pageSize) 
        {
            var count = await entity.CountAsync();
            var items = await entity.Skip((pageNumber - 1) * pageSize)
                                    .Take(pageSize).ToListAsync();
            return new Paged<T>(items, count, pageNumber, pageSize);
        }


    }
}
