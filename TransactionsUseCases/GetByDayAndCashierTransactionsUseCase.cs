using System.Transactions;
using UseCases.DataStorePluginInterfaces;

namespace UseCases.TransactionsUseCases;

public class GetByDayAndCashierTransactionsUseCase : IGetByDayAndCashierTransactionsUseCase
{
    private readonly ITransactionRepository _transactionRepository;

    public GetByDayAndCashierTransactionsUseCase(ITransactionRepository transactionRepository)
    {
        _transactionRepository = transactionRepository;
    }

    public IEnumerable<CoreBusiness.Transaction> Execute(DateTime date, string cashierName)
    {
        return _transactionRepository.GetByDayAndCashier(date, cashierName);
    }
}