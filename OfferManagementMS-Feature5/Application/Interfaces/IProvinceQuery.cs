using Domain.Entities;

namespace Application.Interfaces
{
        public interface IProvinceQuery
        {
            public Task<List<Province>> GetAllProvince();
            public Task<Province> GetProvinceById(int provinceId);

        }
}