namespace CashFlow.Application.UseCases.Report.Pdf;
public interface IGenerateExpensesReportPdfUseCase
{
    Task<byte[]> Execute(DateOnly month);
}
