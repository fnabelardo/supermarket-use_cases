using CoreBusiness;

namespace UseCases.ProductsUseCases;

public interface IViewSelectedProductsUseCase
{
    Product? Execute(int productId, bool loadCategory = false);
}