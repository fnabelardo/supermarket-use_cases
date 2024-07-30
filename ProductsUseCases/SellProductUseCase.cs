using CoreBusiness;
using UseCases.DataStorePluginInterfaces;
using UseCases.TransactionsUseCases;

namespace UseCases.ProductsUseCases;

public class SellProductUseCase : ISellProductUseCase
{
    private readonly IProductRepository _productRepository;
    private readonly IRecordTransactionUseCase _recordTransactionUseCase;

    public SellProductUseCase(IProductRepository productRepository, IRecordTransactionUseCase recordTransactionUseCase)
    {
        _productRepository = productRepository;
        _recordTransactionUseCase = recordTransactionUseCase;
    }

    public void Execute(string cashier, int productId, int qtyToSell)
    {
        var product = _productRepository.GetProductById(productId, true);
        if (product == null) return;

        _recordTransactionUseCase.Execute(cashier, productId, product.Name, product.Price.Value, product.Quantity.Value,
            qtyToSell);
        product.Quantity -= qtyToSell;
        _productRepository.UpdateProduct(productId, product);
    }
}