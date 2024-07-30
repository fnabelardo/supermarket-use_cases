namespace UseCases.ProductsUseCases;

public interface ISellProductUseCase
{
    void Execute(string cashier, int productId, int qtyToSell);
}