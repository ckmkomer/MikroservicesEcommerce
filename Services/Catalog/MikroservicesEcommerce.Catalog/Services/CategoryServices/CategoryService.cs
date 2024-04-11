using AutoMapper;
using MikroservicesEcommerce.Catalog.Dtos.CategoryDtos;
using MikroservicesEcommerce.Catalog.Entities;
using MikroservicesEcommerce.Catalog.Settings;
using MongoDB.Driver;

namespace MikroservicesEcommerce.Catalog.Services.CategoryServices
{
    public class CategoryService : ICategoryService
    {
        private readonly IMongoCollection<Category> _categoryCollection;
        private readonly IMapper _mapper;

        public CategoryService(IMapper mapper , IDatabaseSettings _databaseSettings)
        {
            var client = new MongoClient(_databaseSettings.ConnectionString);
            var database= client.GetDatabase(_databaseSettings.DatabaseName);
            _categoryCollection = database.GetCollection<Category>(_databaseSettings.CategoryCollectionMane);
            _mapper = mapper;
        }

        public Task CreateCategoryAsync(CreateCategoryDto createCategoryDto)
        {
            throw new NotImplementedException();
        }

        public Task DeleteCategoryAsync(string id)
        {
            throw new NotImplementedException();
        }

        public Task<List<ResultCategoryDto>> GetAllCategoryAsync()
        {
            throw new NotImplementedException();
        }

        public Task<GetByIdCategoryDto> GetByIdCategoryAsync(string id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateCategoryAsync(UpdateCategoryDto updateCategoryDto)
        {
            throw new NotImplementedException();
        }
    }
}
