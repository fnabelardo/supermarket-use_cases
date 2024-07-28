using CoreBusiness;
using UseCases.CategoriesUseCases;
using UseCases.DataStorePluginInterfaces;

namespace UseCases.ProductsUseCases;

public class ViewSelectedProductsUseCase : IViewSelectedProductsUseCase
{
    private readonly IProductRepository _productRepository;

    public ViewSelectedProductsUseCase(IProductRepository productRepository)
    {
        _productRepository = productRepository;
    }

    public Product? Execute(int productId, bool loadCategory = false)
    {
        return _productRepository.GetProductById(productId, loadCategory);
    }
}