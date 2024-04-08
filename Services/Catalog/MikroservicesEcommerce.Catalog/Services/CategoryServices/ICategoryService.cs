using MikroservicesEcommerce.Catalog.Dtos.CategoryDtos;

namespace MikroservicesEcommerce.Catalog.Services.CategoryServices
{
    public interface ICategoryService
    {
        Task<List<ResultCategoryDto>> GetAllCategoryAsync();
        Task CreateCategoryAsync (CreateCategoryDto createCategoryDto);
        Task UpdateCategoryAsync (UpdateCategoryDto updateCategoryDto);
        Task DeleteCategoryAsync (String id);
        Task<GetByIdCategoryDto> GetByIdCategoryAsync (String id);


    }
}
