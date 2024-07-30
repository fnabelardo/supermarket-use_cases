namespace UseCases.TransactionsUseCases;

public interface IGetByDayAndCashierTransactionsUseCase
{
    IEnumerable<CoreBusiness.Transaction> Execute(DateTime date, string cashierName);
}