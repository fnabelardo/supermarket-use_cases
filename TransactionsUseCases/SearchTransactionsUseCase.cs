using System.Transactions;
using UseCases.DataStorePluginInterfaces;

namespace UseCases.TransactionsUseCases;

public class SearchTransactionsUseCase : ISearchTransactionsUseCase
{
    private readonly ITransactionRepository _transactionRepository;

    public SearchTransactionsUseCase(ITransactionRepository transactionRepository)
    {
        _transactionRepository = transactionRepository;
    }

    public IEnumerable<CoreBusiness.Transaction> Execute(string cashierName, DateTime startDate, DateTime endDate)
    {
        return _transactionRepository.Search(cashierName, startDate, endDate);
    }
}