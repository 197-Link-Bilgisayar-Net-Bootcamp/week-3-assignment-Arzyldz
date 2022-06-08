
using NLayer.BLL.Repository;
using NLayer.DAL.Models;

namespace NLayer.BLL.Service
{
    public class ProductService : CrudService<Product>
    {
        private readonly CategoryRepository categoryRepository;
        private readonly ProductFeatureRepository productFeatureRepository;
        private readonly UnitOfWork unitOfWork;
        public ProductService(IRepository<Product> iRepo, UnitOfWork unitOfWork, ProductFeatureRepository productFeatureRepository,CategoryRepository categoryRepository) : base(iRepo)
        {
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


            //Category cat = new Category() { 
            //Name="Yeni Categori",
            //Description="Açıklama 1"
            //};

            //ProductFeature productFeature = new ProductFeature()
            //{
            //    Height = 100,
            //    Width = 50
            //};

            //Product product = new Product()
            //{
            //   Name="Ürün1",
            //   UnitPrice=300,
            //   Categories=cat,
            //   ProductFeatures=productFeature

            //};

        }
    }
}
