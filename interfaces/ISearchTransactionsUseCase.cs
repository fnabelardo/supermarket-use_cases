namespace UseCases.TransactionsUseCases;

public interface ISearchTransactionsUseCase
{
    IEnumerable<CoreBusiness.Transaction> Execute(string cashierName, DateTime startDate, DateTime endDate);
}