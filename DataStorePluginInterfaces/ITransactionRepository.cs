using CoreBusiness;

namespace UseCases.DataStorePluginInterfaces;

public interface ITransactionRepository
{
    IEnumerable<CoreBusiness.Transaction> GetByDayAndCashier(DateTime date, string cashierName);
    IEnumerable<CoreBusiness.Transaction> Search(string cashierName, DateTime startDate, DateTime endDate);

    void AddTransaction(string cashierName, int productId, string productName, double productPrice, int beforeQty,
        int soldQty);

    IEnumerable<Transaction> GetByDayTransactions(DateTime date);
}