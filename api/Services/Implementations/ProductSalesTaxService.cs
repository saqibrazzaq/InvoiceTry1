using api.Dtos;
using api.Entities;
using api.Repositories.Interfaces;
using api.Services.Interfaces;
using AutoMapper;

namespace api.Services.Implementations
{
    public class ProductSalesTaxService : IProductSalesTaxService
    {
        private readonly IRepositoryManager _rep;
        private readonly IMapper _mapper;
        public ProductSalesTaxService(IRepositoryManager rep, 
            IMapper mapper)
        {
            _rep = rep;
            _mapper = mapper;
        }

        private ProductSalesTax FindEntityIfExists(int productSalesTaxId, bool trackChanges)
        {
            var entity = _rep.ProductSalesTaxRepository.FindByCondition(
                x => x.ProductSalesTaxId == productSalesTaxId,
                trackChanges)
                .FirstOrDefault();
            if (entity == null) { throw new Exception("Product sales tax not found"); }

            return entity;
        }

        public ProductSalesTaxRes? Create(ProductSalesTaxReqEdit dto)
        {
            var entity = _mapper.Map<ProductSalesTax>(dto);
            _rep.ProductSalesTaxRepository.Create(entity);
            _rep.Save();
            return _mapper.Map<ProductSalesTaxRes>(entity);
        }

        public void Delete(int productSalesTaxId)
        {
            var entity = FindEntityIfExists(productSalesTaxId, true);
            _rep.ProductSalesTaxRepository.Delete(entity);
            _rep.Save();
        }

        public ProductSalesTaxRes? Get(int productSalesTaxId)
        {
            var entity = FindEntityIfExists(productSalesTaxId, false);
            return _mapper.Map<ProductSalesTaxRes>(entity);
        }

        public ProductSalesTaxRes? Update(int productSalesTaxId, ProductSalesTaxReqEdit dto)
        {
            var entity = FindEntityIfExists(productSalesTaxId, true);
            _mapper.Map(dto, entity);
            _rep.Save();
            return _mapper.Map<ProductSalesTaxRes>(entity);
        }
    }
}
