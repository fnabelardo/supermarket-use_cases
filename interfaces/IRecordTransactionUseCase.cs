namespace UseCases.TransactionsUseCases;

public interface IRecordTransactionUseCase
{
    void Execute(string cashierName, int productId, string productName, double productPrice, int beforeQty,
        int soldQty);
}