using CashFlow.Communication.Responses;

namespace CashFlow.Application.UseCases.Expenses.Remove;
public interface IDeleteExpenseUseCase
{
    Task Execute(long id);
}
