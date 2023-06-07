using api.Dtos;
using api.Entities;
using api.Repositories.Interfaces;
using api.Services.Interfaces;
using AutoMapper;

namespace api.Services.Implementations
{
    public class ProductService : IProductService
    {
        private readonly IRepositoryManager _rep;
        private readonly IMapper _mapper;
        public ProductService(IRepositoryManager rep, 
            IMapper mapper)
        {
            _rep = rep;
            _mapper = mapper;
        }

        private Product FindEntityIfExists(int productId, bool trackChanges)
        {
            var entity = _rep.ProductRepository.FindByCondition(
                x => x.ProductId == productId,
                trackChanges)
                .FirstOrDefault();
            if (entity == null) { throw new Exception("Product not found"); }

            return entity;
        }

        public ProductRes? Create(ProductReqEdit dto)
        {
            var entity = _mapper.Map<Product>(dto);
            _rep.ProductRepository.Create(entity);
            _rep.Save();
            return _mapper.Map<ProductRes>(entity);
        }

        public void Delete(int productId)
        {
            var entity = FindEntityIfExists(productId, true);
            _rep.ProductRepository.Delete(entity);
            _rep.Save();
        }

        public ProductRes? Get(int productId)
        {
            var entity = FindEntityIfExists(productId, false);
            return _mapper.Map<ProductRes>(entity);
        }

        public ProductRes? Update(int productId, ProductReqEdit dto)
        {
            var entity = FindEntityIfExists(productId, true);
            _mapper.Map(dto, entity);
            _rep.Save();
            return _mapper.Map<ProductRes>(entity);
        }
    }
}
