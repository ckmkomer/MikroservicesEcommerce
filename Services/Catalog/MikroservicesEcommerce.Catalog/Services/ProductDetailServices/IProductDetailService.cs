using MikroservicesEcommerce.Catalog.Dtos.CategoryDtos;
using MikroservicesEcommerce.Catalog.Dtos.ProductDetailDtos;
using MikroservicesEcommerce.Catalog.Dtos.ProductDtos;

namespace MikroservicesEcommerce.Catalog.Services.ProductDetailServices
{
    public interface IProductDetailService
    {
        Task<List<ResultProductDetailDto>> GetAllProductAsync();
        Task CreateProductDetailAsync(CreateProductDetailDto createProductDetailDto);
        Task UpdateProductDetailAsync(UpdateProductDetailDto updateProductDetailDto);
        Task DeleteProductDetailAsync(String id);
        Task<GetByIdProductDetailDto> GetByIdProductDetailAsync(String id);
    }
}
