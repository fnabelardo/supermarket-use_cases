using CoreBusiness;

namespace UseCases.ProductsUseCases;

public interface IEditProductUseCase
{
    void Execute(int productId, Product product);
}