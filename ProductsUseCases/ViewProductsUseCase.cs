using CoreBusiness;
using UseCases.CategoriesUseCases;
using UseCases.DataStorePluginInterfaces;

namespace UseCases.ProductsUseCases;

public class ViewProductsUseCase : IViewProductsUseCase
{
    private readonly IProductRepository _productRepository;

    public ViewProductsUseCase(IProductRepository productRepository)
    {
        _productRepository = productRepository;
    }

    public IEnumerable<Product> Execute(bool loadCategory)
    {
        return _productRepository.GetProducts(loadCategory);
    }
}