using MikroservicesEcommerce.Catalog.Dtos.CategoryDtos;
using MikroservicesEcommerce.Catalog.Dtos.ProductDtos;

namespace MikroservicesEcommerce.Catalog.Services.ProductServices
{
    public interface IProductService
    {
        Task<List<ResultProductDto>> GetAllProductAsync();
        Task CreateProductAsync(CreateProductyDto createProductyDto);
        Task UpdateProductAsync(UpdateProductDto updateProductDto);
        Task DeleteProductAsync(String id);
        Task<GetByIdProductDto> GetByIdProductAsync(String id);
    }
}
