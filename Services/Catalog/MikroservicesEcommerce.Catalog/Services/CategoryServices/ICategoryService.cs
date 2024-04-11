using MikroservicesEcommerce.Catalog.Dtos.CategoryDtos;

namespace MikroservicesEcommerce.Catalog.Services.CategoryServices
{
    public interface ICategoryService
    {
        Task<List<ResultCategoryDto>> GetAllCategoryAsync();
        Task CreateCategoryAsync (CreateProductyDto createCategoryDto);
        Task UpdateCategoryAsync (UpdateCategoryDto updateCategoryDto);
        Task DeleteCategoryAsync (String id);
        Task<GetByIdCategoryDto> GetByIdCategoryAsync (String id);


    }
}
