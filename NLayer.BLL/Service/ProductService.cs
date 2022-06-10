
using NLayer.BLL.Repository;
using NLayer.DAL.Models;

namespace NLayer.BLL.Service
{
    public class ProductService : CrudService<Product>
    {
        private readonly ProductRepository pRepo;
        private readonly CategoryRepository categoryRepository;
        private readonly ProductFeatureRepository productFeatureRepository;
        private readonly UnitOfWork unitOfWork;
        public ProductService(IRepository<Product> iRepo, UnitOfWork unitOfWork, ProductFeatureRepository productFeatureRepository, CategoryRepository categoryRepository) : base(iRepo)
        {
            this.pRepo = (ProductRepository)iRepo;
            this.unitOfWork = unitOfWork;
            this.productFeatureRepository = productFeatureRepository;
            this.categoryRepository = categoryRepository;
        }
        /// <summary>
        /// Product ona ait Feature ve yeni bir kategori oluşturarak ekleyen metot
        /// </summary>
        /// <returns></returns>
        public async Task CreatAllProduct(Category cat, ProductFeature productFeature, Product product)
        {
            categoryRepository.Add(cat);
            productFeatureRepository.Add(productFeature);
            base.Add(product);
            await unitOfWork.Commit();


        }
        public List<Product> GetCheapProductTop5()
        {
          return (List<Product>)pRepo.GetCheapProductTop5();

        }
       
    }
}
