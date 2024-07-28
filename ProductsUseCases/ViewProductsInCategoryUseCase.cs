using CoreBusiness;
using UseCases.CategoriesUseCases;
using UseCases.DataStorePluginInterfaces;

namespace UseCases.ProductsUseCases;

public class ViewProductsInCategoryUseCase : IViewProductsInCategoryUseCase
{
    private readonly IProductRepository _productRepository;

    public ViewProductsInCategoryUseCase(IProductRepository productRepository)
    {
        _productRepository = productRepository;
    }

    public IEnumerable<Product> Execute(int categoryId)
    {
        return _productRepository.GetProductsByCategoryId(categoryId);
    }
}