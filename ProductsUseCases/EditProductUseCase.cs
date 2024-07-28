using CoreBusiness;
using UseCases.DataStorePluginInterfaces;

namespace UseCases.ProductsUseCases;

public class EditProductUseCase : IEditProductUseCase
{
    private readonly IProductRepository _productRepository;

    public EditProductUseCase(IProductRepository productRepository)
    {
        _productRepository = productRepository;
    }
    
    public void Execute(int productId, Product product)
    {
        _productRepository.UpdateProduct(productId, product);
    }
}