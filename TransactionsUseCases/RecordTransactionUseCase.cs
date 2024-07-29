using CoreBusiness;
using UseCases.DataStorePluginInterfaces;

namespace UseCases.TransactionsUseCases;

public class RecordTransactionUseCase : IRecordTransactionUseCase
{
    private readonly ITransactionRepository _transactionRepository;

    public RecordTransactionUseCase(ITransactionRepository transactionRepository)
    {
        _transactionRepository = transactionRepository;
    }

    public void Execute(string cashierName, int productId, string productName, double productPrice, int beforeQty,
        int soldQty)
    {
        _transactionRepository.AddTransaction(cashierName, productId, productName, productPrice, beforeQty,
            soldQty);
    }
}