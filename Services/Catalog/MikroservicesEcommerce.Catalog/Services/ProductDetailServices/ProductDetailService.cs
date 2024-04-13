using AutoMapper;
using MikroservicesEcommerce.Catalog.Dtos.ProductDetailDtos;
using MikroservicesEcommerce.Catalog.Entities;
using MikroservicesEcommerce.Catalog.Settings;
using MongoDB.Driver;

namespace MikroservicesEcommerce.Catalog.Services.ProductDetailServices
{
    public class ProductDetailService : IProductDetailService
    {

        private readonly IMongoCollection<ProductDetail> _productDetailCollection;
        private readonly IMapper _mapper;

        public ProductDetailService(IMapper mapper ,IDatabaseSettings _databaseSettings)
        {
            var client = new MongoClient(_databaseSettings.ConnectionString);
            var databese = client.GetDatabase(_databaseSettings.ProductDetailCollectionName);
            _productDetailCollection = databese.GetCollection<ProductDetail>(_databaseSettings.ProductDetailCollectionName);
            _mapper = mapper;
        }

        public async Task CreateProductDetailAsync(CreateProductDetailDto createProductDetailDto)
        {
            var values = _mapper.Map<ProductDetail>(createProductDetailDto);
            await _productDetailCollection.InsertOneAsync(values);
        }

        public async Task DeleteProductDetailAsync(string id)
        {
            await _productDetailCollection.DeleteOneAsync(id);
        }

        public async Task<List<ResultProductDetailDto>> GetAllProductAsync()
        {
            var values = await _productDetailCollection.Find(c)
        }

        public Task<GetByIdProductDetailDto> GetByIdProductDetailAsync(string id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateProductDetailAsync(UpdateProductDetailDto updateProductDetailDto)
        {
            throw new NotImplementedException();
        }
    }
}
